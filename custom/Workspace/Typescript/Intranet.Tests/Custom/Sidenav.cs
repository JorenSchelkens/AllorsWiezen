namespace Tests.Intranet
{
    using Allors.Meta;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    using Tests.Components;
    using Tests.Components.Html;
    using Tests.Intranet.PersonTests;

    public class Sidenav : Page
    {
        public Sidenav(IWebDriver driver)
        : base(driver)
        {
            this.Selector = By.CssSelector("mat-sidenav");
        }

        public By Selector { get; }

        public Anchor Home => new Anchor(this.Driver, this.ByHref("/"));

        public Element ContactsGroup => this.Group("Contacts");

        public Anchor People => this.Link(M.Person.ObjectType);
        
        public Anchor Organisations => this.Link(M.Organisation.ObjectType);

        public Button Toggle => new Button(this.Driver, By.CssSelector("button[aria-label='Toggle sidenav']"));

        public DashboardPage NavigateToHome()
        {
            this.Home.Click();

            return new DashboardPage(this.Driver);
        }

        public PersonListPage NavigateToPersonList()
        {
            this.Navigate(this.ContactsGroup, this.People);
            return new PersonListPage(this.Driver);
        }

        private void Navigate(Element group, Anchor link)
        {
            this.Driver.WaitForAngular();

            if (!link.IsVisble)
            {
                if (!group.IsVisible)
                {
                    this.Toggle.Click();
                    this.Driver.WaitForCondition(driver => @group.IsVisible);
                }
               
                group.Click();
            }

            link.Click();
        }

        private Element Group(string name)
        {
            return new Element(this.Driver, new ByChained(this.Selector, By.XPath($"//span[contains(text(), '{name}')]")));
        }

        private Anchor Link(string href)
        {
            return new Anchor(this.Driver, this.ByHref(href));
        }

        private Anchor Link(ObjectType objectType)
        {
            return new Anchor(this.Driver, this.ByObjectType(objectType));
        }

        private By ByHref(string href)
        {
            return new ByChained(this.Selector, By.CssSelector($"a[href='{href}']"));
        }

        private By ByObjectType(ObjectType objectType)
        {
            return new ByChained(this.Selector, By.CssSelector($"a[data-allors-id='{objectType.IdAsNumberString}']"));
        }
    }
}
