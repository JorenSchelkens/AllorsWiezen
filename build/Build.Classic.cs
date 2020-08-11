using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Npm;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    Target ClassicGenerate => _ => _
        .After(Clean)
        .Executes(() =>
        {
            DotNetRun(s => s
                .SetProjectFile(Paths.PlatformRepositoryGenerate)
                .SetApplicationArguments($"{Paths.ClassicRepositoryDomainRepository} {Paths.PlatformRepositoryTemplatesMetaCs} {Paths.ClassicDatabaseMetaGenerated}"));
            DotNetRun(s => s
                .SetWorkingDirectory(Paths.Classic)
                .SetProjectFile(Paths.ClassicDatabaseGenerate));
        });

    Target ClassicTest => _ => _
        .DependsOn(ClassicGenerate)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Paths.ClassicDatabaseDomainTests)
                .SetLogger("trx;LogFileName=classic.trx")
                .SetResultsDirectory(Paths.ArtifactsTests));
        });

    Target Classic => _ => _
        .After(Clean)
        .DependsOn(ClassicTest);
}
