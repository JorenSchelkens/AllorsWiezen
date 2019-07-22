namespace Allors.Domain
{
    using System.Linq;

    public partial class Statistic
    {
        public void CustomOnDerive(ObjectOnDerive method)
        {
            var chat = this.ChatWhereStatistic;
            var messages = chat.Messages.Where(v=>v.Author.Equals(this.Participant));

            this.MessageCount = messages.Count();
        }
    }
}