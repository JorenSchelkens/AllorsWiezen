namespace Allors.Domain
{
    using Allors.Meta;

    public partial class Setingses
    {
        protected override void CustomPrepare(Setup config)
        {
            base.CustomPrepare(config);

            config.AddDependency(this.ObjectType, M.Singleton.ObjectType);
        }

        protected override void CustomSetup(Setup setup)
        {
            var singleton = this.Session.GetSingleton();
            singleton.Settings = new SettingsBuilder(this.Session).Build();

            singleton.Settings.Counter = new CounterBuilder(this.Session).Build();
            singleton.Settings.Setting = "Ok";
        }
    }
}
