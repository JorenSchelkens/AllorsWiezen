using Nuke.Common.IO;

public partial class Paths
{
    public AbsolutePath Classic => Root / "classic";
    public AbsolutePath ClassicRepositoryDomainRepository => Classic / "Repository/Domain/Repository.csproj";
    public AbsolutePath ClassicDatabaseMetaGenerated => Classic / "Database/Meta/generated";
    public AbsolutePath ClassicDatabaseGenerate => Classic / "Database/Generate/Generate.csproj";
    public AbsolutePath ClassicDatabaseCommands => Classic / "Database/Commands";
    public AbsolutePath ClassicDatabaseServer => Classic / "Database/Server";
    public AbsolutePath ClassicDatabaseDomainTests => Classic / "Database/Domain.Tests/Domain.Tests.csproj";
}

