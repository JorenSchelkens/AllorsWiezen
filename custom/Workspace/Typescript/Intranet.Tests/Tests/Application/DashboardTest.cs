namespace Tests.ApplicationTests
{
    using Allors.Domain;
    using Components;
    using src.app.dashboard;
    using Xunit;

    [Collection("Test collection")]
    public class DashboardTest : Test
    {
        public DashboardTest(TestFixture fixture)
            : base(fixture)
        {
            this.Login();
            
        }

        [Fact]
        public async void CreateGame()
        {
            var gamesBefore = this.Session.Extent<Game>().ToArray();
           
            var dashboard = new DashboardComponent(this.Driver);
            dashboard.CreateGame.Click();

            this.Driver.WaitForAngular();

            this.Session.Rollback();
            var gamesAfter = this.Session.Extent<Game>().ToArray();

            Assert.Equal(gamesBefore.Length + 1, gamesAfter.Length);
        }
    }
}
