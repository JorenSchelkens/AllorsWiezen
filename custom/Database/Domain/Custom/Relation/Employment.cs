namespace Allors.Domain
{
    using System.Linq;

    public partial class Employment
    {
        public void CustomOnPostBuild(ObjectOnPostBuild method)
        {
            if (!this.ExistFrom)
            {
                this.From = this.strategy.Session.Now();
            }
        }
    }
}
