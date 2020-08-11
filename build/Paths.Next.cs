using Nuke.Common.IO;

public partial class Paths
{
    public AbsolutePath Next => Root / "next";
    public AbsolutePath NextRepositoryDomainRepository => Next / "Repository/Domain/Repository.csproj";
    public AbsolutePath NextDatabaseMetaGenerated => Next / "Database/Meta/generated";
    public AbsolutePath NextDatabaseGenerate => Next / "Database/Generate/Generate.csproj";
    public AbsolutePath NextDatabaseCommands => Next / "Database/Commands";
    public AbsolutePath NextDatabaseServer => Next / "Database/Server";
    public AbsolutePath NextDatabaseDomainTests => Next / "Database/Domain.Tests/Domain.Tests.csproj";
}

