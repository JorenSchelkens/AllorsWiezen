namespace Tests.Intranet.PersonTests
{
    using System.Linq;

    using Allors.Domain;

    using Tests.Components;

    using Xunit;

    [Collection("Test collection")]
    public class PersonEditTest : Test
    {
        private readonly PersonListPage people;

        public PersonEditTest(TestFixture fixture)
            : base(fixture)
        {
            var dashboard = this.Login();
            this.people = dashboard.Sidenav.NavigateToPersonList();
        }

        [Fact]
        public void Create()
        {
            this.people.AddNew.Click();
            var before = new People(this.Session).Extent().ToArray();

            var page = new PersonEditPage(this.Driver);

            page.FirstName.Value = "Jos";
            page.MiddleName.Value = "de";
            page.LastName.Value = "Smos";

            page.Save.Click();

            this.Driver.WaitForAngular();
            this.Session.Rollback();

            var after = new People(this.Session).Extent().ToArray();

            Assert.Equal(after.Length, before.Length + 1);

            var person = after.Except(before).First();

            Assert.Equal("Jos", person.FirstName);
            Assert.Equal("de", person.MiddleName);
            Assert.Equal("Smos", person.LastName);
        }

        [Fact]
        public void Edit()
        {
            var before = new People(this.Session).Extent().ToArray();

            var person = before.First(v => v.FirstName.Equals("John"));
            var id = person.Id;

            var personOverview = this.people.Select(person);
            var page = personOverview.Edit();

            page.FirstName.Value = "Jos";
            page.MiddleName.Value = "de";
            page.LastName.Value = "Smos";

            page.Save.Click();

            this.Driver.WaitForAngular();
            this.Session.Rollback();

            var after = new People(this.Session).Extent().ToArray();

            Assert.Equal(after.Length, before.Length);

            person = after.First(v => v.Id.Equals(id));

            Assert.Equal("Jos", person.FirstName);
            Assert.Equal("de", person.MiddleName);
            Assert.Equal("Smos", person.LastName);
        }
    }
}
