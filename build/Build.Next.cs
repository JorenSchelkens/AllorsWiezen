using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Npm;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    Target NextGenerate => _ => _
        .After(Clean)
        .Executes(() =>
        {
            DotNetRun(s => s
                .SetProjectFile(Paths.PlatformRepositoryGenerate)
                .SetApplicationArguments($"{Paths.NextRepositoryDomainRepository} {Paths.PlatformRepositoryTemplatesMetaCs} {Paths.NextDatabaseMetaGenerated}"));
            DotNetRun(s => s
                .SetWorkingDirectory(Paths.Next)
                .SetProjectFile(Paths.NextDatabaseGenerate));
        });

    Target NextTest => _ => _
        .DependsOn(NextGenerate)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Paths.NextDatabaseDomainTests)
                .SetLogger("trx;LogFileName=next.trx")
                .SetResultsDirectory(Paths.ArtifactsTests));
        });

    Target Next => _ => _
        .After(Clean)
        .DependsOn(NextTest);
}
