using Nuke.Common.IO;

public partial class Paths
{
    public AbsolutePath Security => Root / "security";
    public AbsolutePath SecurityRepositoryDomainRepository => Security / "Repository/Domain/Repository.csproj";
    public AbsolutePath SecurityDatabaseMetaGenerated => Security / "Database/Meta/generated";
    public AbsolutePath SecurityDatabaseGenerate => Security / "Database/Generate/Generate.csproj";
    public AbsolutePath SecurityDatabaseCommands => Security / "Database/Commands";
    public AbsolutePath SecurityDatabaseServer => Security / "Database/Server";
    public AbsolutePath SecurityDatabaseDomainTests => Security / "Database/Domain.Tests/Domain.Tests.csproj";
}

