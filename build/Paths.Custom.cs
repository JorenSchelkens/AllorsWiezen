using static Nuke.Common.IO.PathConstruction;

public partial class Paths
{
    public AbsolutePath Custom => Root / "custom";
    public AbsolutePath CustomRepositoryDomainRepository => Custom / "Repository/Domain/Repository.csproj";
    public AbsolutePath CustomDatabaseMetaGenerated => Custom / "Database/Meta/generated";
    public AbsolutePath CustomDatabaseGenerate => Custom / "Database/Generate/Generate.csproj";
    public AbsolutePath CustomDatabaseCommands => Custom / "Database/Commands";
    public AbsolutePath CustomDatabaseServer => Custom / "Database/Server";
    public AbsolutePath CustomDatabaseDomainTests => Custom / "Database/Domain.Tests/Domain.Tests.csproj";

    public AbsolutePath CustomWorkspaceCSharp => Custom / "Workspace/CSharp";
    public AbsolutePath CustomWorkspaceCSharpExcelAddIn => CustomWorkspaceCSharp / "ExcelAddIn";
    public AbsolutePath CustomWorkspaceCSharpExcelAddInProject => CustomWorkspaceCSharpExcelAddIn / "ExcelAddIn.csproj";
    public AbsolutePath CustomWorkspaceCSharpExcelAddInProjectSignTool => CustomWorkspaceCSharpExcelAddIn / "signtool.exe";
    
    public AbsolutePath CustomWorkspaceTypescriptDomain => Custom / "Workspace/Typescript/Domain";
    public AbsolutePath CustomWorkspaceTypescriptIntranet => Custom / "Workspace/Typescript/Intranet";
    public AbsolutePath CustomWorkspaceTypescriptIntranetTests => Custom / "Workspace/Typescript/Intranet.Tests/Intranet.Tests.csproj";
    public AbsolutePath CustomWorkspaceTypescriptAutotestAngular => Custom / "Workspace/Typescript/Autotest/Angular";
    public AbsolutePath CustomWorkspaceTypescriptAutotestGenerateGenerate => Custom / "Workspace/Typescript/Autotest/Generate/Generate.csproj";
    public AbsolutePath[] CustomWorkspaceTypescript => new[]
    {
        CustomWorkspaceTypescriptDomain,
        CustomWorkspaceTypescriptIntranet,
        CustomWorkspaceTypescriptAutotestAngular
    };
}
