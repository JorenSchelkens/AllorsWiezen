namespace Tests.Intranet.PersonTests
{
    using OpenQA.Selenium;

    using Tests.Components.Html;
    using Tests.Components.Material;
    using Tests.Intranet;

    public class PersonOverviewPage : MainPage
    {
        public PersonOverviewPage(IWebDriver driver)
            : base(driver)
        {
        }

        public Element DetailPanel => new Element(this.Driver, By.CssSelector("div[data-allors-panel='detail']"));

        public MaterialTable Table => new MaterialTable(this.Driver);

        public Anchor AddNew => new Anchor(this.Driver, By.CssSelector("[mat-fab]"));

        public Anchor List => new Anchor(this.Driver, By.CssSelector("a[href='/contacts/people']"));

        public PersonEditPage Edit()
        {
            this.DetailPanel.Click();
            return new PersonEditPage(this.Driver);
        }
    }
}
