namespace Allors.Domain
{
    public partial class Organisations
    {
        protected override void CustomSecure(Security config)
        {
            var full = new[] { Operations.Read, Operations.Write, Operations.Execute };

            config.GrantAdministrator(this.ObjectType, full);
            config.GrantCreator(this.ObjectType, full);
        }
    }
}
