namespace Allors
{
    using System.IO;

    using Allors.Domain;

    public class Demo
    {
        private readonly ISession Session;

        private readonly DirectoryInfo DataPath;

        public Demo(ISession session, DirectoryInfo dataPath)
        {
            this.Session = session;
            this.DataPath = dataPath;
        }

        public void Execute()
        {
            var singleton = this.Session.GetSingleton();
            var dutchLocale = new Locales(this.Session).DutchNetherlands;
            singleton.AddAdditionalLocale(dutchLocale);

            var john = new PersonBuilder(this.Session).WithFirstName("John").WithLastName("Doe").Build();
            var jane = new PersonBuilder(this.Session).WithFirstName("Jane").WithLastName("Doe").Build();
            
            this.SetupUser(john);
            this.SetupUser(jane);
            
            var allors = new OrganisationBuilder(this.Session).WithName("Allors").Build();
            var acme = new OrganisationBuilder(this.Session).WithName("Acme").Build();

            new EmploymentBuilder(this.Session).WithEmployer(acme).WithEmployee(john).Build();
            new EmploymentBuilder(this.Session).WithEmployer(acme).WithEmployee(jane).Build();
        }

        private void SetupUser(Person john)
        {
            new UserGroups(this.Session).Administrators.AddMember(john);
            new UserGroups(this.Session).Creators.AddMember(john);

            john.SetPassword("password");
        }
    }
}