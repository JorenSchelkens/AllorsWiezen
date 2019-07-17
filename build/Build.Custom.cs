using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.Tools.Npm;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;

partial class Build
{
    Target CustomGenerate => _ => _
        .After(Clean)
        .Executes(() =>
        {
            DotNetRun(s => s
                .SetProjectFile(Paths.PlatformRepositoryGenerate)
                .SetApplicationArguments($"{Paths.CustomRepositoryDomainRepository} {Paths.PlatformRepositoryTemplatesMetaCs} {Paths.CustomDatabaseMetaGenerated}"));
            DotNetRun(s => s
                .SetWorkingDirectory(Paths.Custom)
                .SetProjectFile(Paths.CustomDatabaseGenerate));
        });

    Target CustomDatabaseTestDomain => _ => _
        .DependsOn(CustomGenerate)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Paths.CustomDatabaseDomainTests)
                .SetLogger("trx;LogFileName=CustomDatabaseDomain.trx")
                .SetResultsDirectory(Paths.ArtifactsTests));
        });

    Target CustomPublishCommands => _ => _
        .DependsOn(CustomGenerate)
        .Executes(() =>
        {
            var dotNetPublishSettings = new DotNetPublishSettings()
                .SetWorkingDirectory(Paths.CustomDatabaseCommands)
                .SetOutput(Paths.ArtifactsCustomCommands);
            DotNetPublish(dotNetPublishSettings);
        });

    Target CustomPublishServer => _ => _
        .DependsOn(CustomGenerate)
        .Executes(() =>
        {
            var dotNetPublishSettings = new DotNetPublishSettings()
                .SetWorkingDirectory(Paths.CustomDatabaseServer)
                .SetOutput(Paths.ArtifactsCustomServer);
            DotNetPublish(dotNetPublishSettings);
        });

    Target CustomPublishExcellAddIn => _ => _
        .DependsOn(CustomPublishServer)
        .DependsOn(CustomPublishCommands)
        .Executes(() =>
        {
            try
            {
                CopyFile(Paths.SignTool, Paths.CustomWorkspaceCSharpExcelAddInProjectSignTool, FileExistsPolicy.Overwrite);

                var msBuildSettings = new MSBuildSettings()
                    .SetConfiguration(Configuration)
                    .SetRestore(true)
                    .SetProjectFile(Paths.CustomWorkspaceCSharpExcelAddInProject)
                    .AddProperty("InstallUrl", "https://server.custom.net/excel/")
                    .SetTargets("Publish");
                MSBuild(msBuildSettings);
                
                DeleteDirectory(Paths.ArtifactsCustomExcellAddIn);
                CopyDirectoryRecursively(Paths.CustomWorkspaceCSharpExcelAddIn / "bin" / Configuration / "app.publish", Paths.ArtifactsCustomExcellAddIn);
            }
            finally
            {
                DeleteFile(Paths.CustomWorkspaceCSharpExcelAddInProjectSignTool);
            }
        });

    Target CustomWorkspaceNpmInstall => _ => _
        .After(Clean)
        .Executes(() =>
        {
            foreach (var path in Paths.CustomWorkspaceTypescript)
            {
                NpmInstall(s => s
                    .SetEnvironmentVariable("npm_config_loglevel", "silent")
                    .SetWorkingDirectory(path));
            }
        });

    Target CustomWorkspaceSetup => _ => _
        .DependsOn(CustomWorkspaceNpmInstall)
        .DependsOn(CustomGenerate);

    Target CustomWorkspaceAutotest => _ => _
        .DependsOn(CustomWorkspaceSetup)
        .Executes(() =>
        {
            foreach (var path in new[] { Paths.CustomWorkspaceTypescriptIntranet, Paths.CustomWorkspaceTypescriptAutotestAngular })
            {
                NpmRun(s => s
                    .SetEnvironmentVariable("npm_config_loglevel", "silent")
                    .SetWorkingDirectory(path)
                    .SetCommand("autotest"));
            }

            DotNetRun(s => s
                .SetWorkingDirectory(Paths.Custom)
                .SetProjectFile(Paths.CustomWorkspaceTypescriptAutotestGenerateGenerate));
        });

    Target CustomWorkspaceTypescriptDomain => _ => _
        .DependsOn(CustomWorkspaceSetup)
        .DependsOn(EnsureDirectories)
        .Executes(() =>
        {
            NpmRun(s => s
                .SetEnvironmentVariable("npm_config_loglevel", "silent")
                .SetWorkingDirectory(Paths.CustomWorkspaceTypescriptDomain)
                .SetArguments("--reporter-options", $"output={Paths.ArtifactsTestsCustomWorkspaceTypescriptDomain}")
                .SetCommand("az:test"));
        });

    Target CustomWorkspaceTypescriptIntranetTests => _ => _
        .DependsOn(CustomWorkspaceAutotest)
        .DependsOn(CustomPublishServer)
        .DependsOn(CustomPublishCommands)
        .Executes(async () =>
        {
            using (var sqlServer = new SqlServer())
            {
                sqlServer.Restart();
                sqlServer.Populate(Paths.ArtifactsCustomCommands);

                using (var server = new Server(Paths.ArtifactsCustomServer))
                {
                    using (var angular = new Angular(Paths.CustomWorkspaceTypescriptIntranet))
                    {
                        await server.Ready();
                        await angular.Init();
                        DotNetTest(s => s
                            .SetProjectFile(Paths.CustomWorkspaceTypescriptIntranetTests)
                            .SetLogger("trx;LogFileName=CustomWorkspaceTypescriptIntranetTests.trx")
                            .SetResultsDirectory(Paths.ArtifactsTests));
                    }
                }
            }
        });
    
    Target CustomDatabaseTest => _ => _
        .DependsOn(CustomDatabaseTestDomain);

    Target CustomWorkspaceTest => _ => _
        .DependsOn(CustomWorkspaceTypescriptDomain)
        .DependsOn(CustomWorkspaceTypescriptIntranetTests);

    Target CustomTest => _ => _
        .After(Clean)
        .DependsOn(CustomDatabaseTest)
        .DependsOn(CustomWorkspaceTest);

    Target Custom => _ => _
        .DependsOn(Clean)
        .DependsOn(CustomTest);
}
