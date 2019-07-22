namespace Allors.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Chat
    {
        public void CustomOnPreDerive(ObjectOnPreDerive method)
        {
            var derivation = method.Derivation;

            foreach(Object statistic in this.Statistics)
            {
                derivation.AddDependency(statistic, this);
            }
        }

        public void CustomOnDerive(ObjectOnDerive method)
        {
            this.Participants = this.Messages.Select(v => v.Author).ToArray();

            this.Sync();
        }

        private void Sync()
        {
            var participants = new List<Person>(this.Participants);

            // Fase1: Verwijderen van overbodige statistics en
            //        bijhouden van participants zonder statistics
            foreach(Statistic statistic in this.Statistics)
            {
                var participant = statistic.Participant;
                if (participants.Contains(participant))
                {
                    // verwijder participants die al een statistic hebben
                    participants.Remove(participant);
                }
                else
                {
                    // delete statistic waarvan de participant niet meer voorkomt
                    statistic.Delete();
                }
            }

            // Fase2: creeer statistics voor de participants die nog geen
            //        statistic hadden
            foreach(var participant in participants)
            {
                var statistic = new StatisticBuilder(this.strategy.Session)
                    .WithParticipant(participant)
                    .Build();

                this.AddStatistic(statistic);
            }
        }
    }
}