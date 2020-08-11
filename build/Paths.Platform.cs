using Nuke.Common.IO;

public partial class Paths
{
    public AbsolutePath Platform => Root / "allors/platform";
    public AbsolutePath PlatformRepositoryTemplates => Platform / "Repository/Templates";
    public AbsolutePath PlatformRepositoryTemplatesMetaCs => PlatformRepositoryTemplates / "meta.cs.stg";
    public AbsolutePath PlatformRepositoryGenerate => Platform / "Repository/Generate/Generate.csproj";
}
