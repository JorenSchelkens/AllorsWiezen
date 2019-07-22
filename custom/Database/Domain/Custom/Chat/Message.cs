namespace Allors.Domain
{
    public partial class Message
    {
        public void CustomOnPostBuild(ObjectOnPostBuild method)
        {
            if (!this.ExistDate)
            {
                this.Date = this.strategy.Session.Now();
            }


            if (!this.ExistAuthor)
            {
                this.Author = this.strategy.Session.GetUser() as Person;
            }
        }
    }
}