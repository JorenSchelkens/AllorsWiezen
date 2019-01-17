namespace Allors.Meta
{
    public partial class MetaOrganisation
    {
        internal override void CustomExtend()
        {
            this.Delete.Workspace = true;
        }
    }
}