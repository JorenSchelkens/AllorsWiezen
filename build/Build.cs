using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
partial class Build : NukeBuild
{
    Target Clean => _ => _
        .Executes(() =>
        {
            void Delete(DirectoryInfo directoryInfo)
            {
                directoryInfo.Refresh();
                if (directoryInfo.Exists)
                {
                    if (new[] { "node_modules", "packages", "out-tsc", "bin", "obj", "generated" }.Contains(directoryInfo.Name.ToLowerInvariant()))
                    {
                        DeleteDirectory(directoryInfo.FullName);
                        return;
                    }

                    if (!directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
                    {
                        foreach (var child in directoryInfo.GetDirectories())
                        {
                            Delete(child);
                        }
                    }
                }
            }

            foreach (var path in new AbsolutePath[] { Paths.Platform, Paths.Classic })
            {
                foreach (var child in new DirectoryInfo(path).GetDirectories().Where(v => !v.Name.Equals("build")))
                {
                    Delete(child);
                }
            }

            EnsureCleanDirectory(Paths.Artifacts);
        });

    Target Default => _ => _
        .DependsOn(ClassicGenerate)
        .DependsOn(NextGenerate)
        .DependsOn(SecurityGenerate);
}
