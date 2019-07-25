using System;
using System.Collections.Generic;

namespace Allors.Domain
{
    public partial class Score
    {

        public void CustomOnDerive(ObjectOnDerive method)
        {
            var game = this.GameWhereScore;
            if (game.ExistEndDate && game.ExistGameType)
            {

                var gameType = game.GameType;

                var winning = game.Winners.Contains(this.Player);

                if (gameType.IsMiserie)
                {
                    this.Value = winning ? 5 : -5;
                }

                if (gameType.IsSoloSlim)
                {
                    this.Value = winning ? 15 : -15;
                }


            }
            else
            {
                this.RemoveValue();
            }

        }
    }
}
