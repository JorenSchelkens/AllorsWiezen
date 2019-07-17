using static Nuke.Common.IO.PathConstruction;

public partial class Paths
{
    public AbsolutePath Artifacts => Root / "artifacts";
    public AbsolutePath ArtifactsTests => Artifacts / "Tests";
    public AbsolutePath ArtifactsTestsCustomWorkspaceTypescriptDomain => ArtifactsTests / "CustomWorkspaceTypescriptDomain.trx";

    public AbsolutePath ArtifactsCustom => Artifacts / "Custom";
    public AbsolutePath ArtifactsCustomCommands => ArtifactsCustom / "Commands";
    public AbsolutePath ArtifactsCustomServer => ArtifactsCustom / "Server";
    public AbsolutePath ArtifactsCustomIntranet => ArtifactsCustom / "Intranet";
    public AbsolutePath ArtifactsCustomExcellAddIn => ArtifactsCustom / "ExcelAddIn";
}
