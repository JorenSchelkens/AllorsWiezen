namespace Tests
{
    using System.IO;
    using Allors;

    public class IntranetPopulation
    {
        private readonly ISession Session;

        private readonly DirectoryInfo DataPath;

        public IntranetPopulation(ISession session, DirectoryInfo dataPath)
        {
            this.Session = session;
            this.DataPath = dataPath;
        }

        public void Execute()
        {
            this.Session.Derive();
        }
    }
}