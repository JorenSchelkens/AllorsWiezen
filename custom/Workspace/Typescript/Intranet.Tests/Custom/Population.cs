namespace Tests.Intranet
{
    using System.IO;

    using Allors;
    using Allors.Domain;

    public class Population
    {
        private readonly ISession Session;

        private readonly DirectoryInfo DataPath;

        public Population(ISession session, DirectoryInfo dataPath)
        {
            this.Session = session;
            this.DataPath = dataPath;
        }

        public void Execute()
        {
            var singleton = this.Session.GetSingleton();
            var dutchLocale = new Locales(this.Session).DutchNetherlands;
            singleton.AddAdditionalLocale(dutchLocale);

            var person = new PersonBuilder(this.Session).WithFirstName("John").WithLastName("Doe").Build();

            new UserGroups(this.Session).Administrators.AddMember(person);
            new UserGroups(this.Session).Creators.AddMember(person);

            person.SetPassword("password");
        }
    }
}