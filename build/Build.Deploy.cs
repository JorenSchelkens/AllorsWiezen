using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.Npm;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.IO;
using static Nuke.Common.Tools.Npm.NpmTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    Target Publish => _ => _
        .After(Clean)
        .DependsOn(CustomWorkspaceSetup)
        .DependsOn(CustomPublishServer)
        .DependsOn(CustomPublishCommands)
        .Executes(async () =>
        {
            NpmRun(s => s
                .SetEnvironmentVariable("npm_config_loglevel", "silent")
                .SetWorkingDirectory(Paths.CustomWorkspaceTypescriptIntranet)
                .SetArguments("build", "--prod", "--output-path", $"{Paths.ArtifactsCustomIntranet}")
                .SetCommand("ng-high-memory"));
        });

    Target Deploy => _ => _
        .DependsOn(Clean)
        .DependsOn(Publish)
        .Executes(
            async () =>
            {
                using (var iis = new IIS())
                {
                    foreach (var path in Paths.Deploy)
                    {
                        DeleteDirectory(path);
                    }

                    CopyDirectoryRecursively(Paths.ArtifactsCustomCommands, Paths.DeployCommands);
                    CopyDirectoryRecursively(Paths.ArtifactsCustomServer, Paths.DeployServer);
                    CopyDirectoryRecursively(Paths.ArtifactsCustomIntranet, Paths.DeployIntranet);

                    DotNetRun(s => s
                      .SetProjectFile(Paths.CustomDatabaseCommands)
                      .SetApplicationArguments($"populate"));

                    DotNetRun(s => s
                     .SetProjectFile(Paths.CustomDatabaseCommands)
                     .SetApplicationArguments($"integrate"));
                }
            });
}
