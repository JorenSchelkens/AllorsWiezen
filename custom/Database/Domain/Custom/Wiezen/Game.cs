using System;
using System.Collections.Generic;
using System.Linq;

namespace Allors.Domain
{
    public partial class Game
    {
        public void CustomOnPreDerive(ObjectOnPreDerive method)
        {
            var derivation = method.Derivation;

            foreach (Object score in this.Scores)
            {
                derivation.AddDependency(score, this);
            }
        }

        public void CustomOnDerive(ObjectOnDerive method)
        {
            var validation = method.Derivation.Validation;

            if (this.ExistStartDate && this.ExistEndDate)
            {
                if (this.EndDate.Value <= this.StartDate.Value)
                {
                    validation.AddError(new DerivationErrorGeneric(validation, this, this.Meta.EndDate, "End date should be after start date"));
                }
            }
            this.Defenders = this.ScoreboardWhereGame?.Players.Except(this.Declarers).ToArray();

            this.Sync();

        }
        private void Sync()
        {
            if (this.ExistScoreboardWhereGame)
            {
                var players = new List<Person>(this.ScoreboardWhereGame.Players);

                // Fase1: Verwijderen van overbodige statistics en
                //        bijhouden van participants zonder statistics
                foreach (Score score in this.Scores)
                {
                    var player = score.Player;
                    if (players.Contains(player))
                    {
                        // verwijder participants die al een statistic hebben
                        players.Remove(player);
                    }
                    else
                    {
                        // delete statistic waarvan de participant niet meer voorkomt
                        score.Delete();
                    }
                }

                // Fase2: creeer statistics voor de participants die nog geen
                //        statistic hadden
                foreach (var player in players)
                {
                    var score = new ScoreBuilder(this.strategy.Session)
                        .WithPlayer(player)
                        .Build();

                    this.AddScore(score);
                }

            }
            else
            {
                foreach(Score score in this.Scores)
                {
                    score.Delete();
                }
            }

        }
    }
}
