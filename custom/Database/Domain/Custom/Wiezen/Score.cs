using System;
using System.Collections.Generic;
using System.Linq;

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
                var declarers = game.Declarers.ToList();
                var winners = game.Winners.ToList();

                var winning = winners.Contains(this.Player);
                var declaring = declarers.Contains(this.Player);


                if (gameType.IsMiserie || gameType.IsMiserieOpTafel)
                {
                    // 
                    switch (declarers.Count)
                    {
                        case 1:
                            if (declaring)
                            {
                                this.Value = winning ? 15 : -15;
                            }
                            else
                            {
                                this.Value = winners.Count() == 0 ? 5 : -5;
                            }
                            break;
                        case 2:
                            if (declaring)
                            {
                                switch (winners.Count())
                                {
                                    case 0:
                                        this.Value = -15;
                                        break;
                                    case 1:
                                        this.Value = winning ? 15 : -15;
                                        break;
                                    default:
                                        this.Value = 15;
                                        break;
                                }
                            }
                            else
                            {
                                switch (winners.Count())
                                {
                                    case 0:
                                        this.Value = 15;
                                        break;
                                    case 1:
                                        this.Value = 0;
                                        break;
                                    default:
                                        this.Value = -15;
                                        break;
                                }
                            }
                            break;
                        case 4:
                            if (declaring)
                            {
                                switch (winners.Count())
                                {
                                    case 0:
                                        this.Value = 0;
                                        break;
                                    case 1:
                                        this.Value = winning ? 45 : -15;
                                        break;
                                    case 2:
                                        this.Value = winning ? 15 : -15;
                                        break;
                                    default:
                                        this.Value = winning ? 15 : -45;
                                        break;
                                }
                            }
                            break;
                    }
                    if (gameType.IsMiserieOpTafel)
                    {
                        this.Value = this.Value * 2;
                    }
                }

                if (gameType.IsSoloSlim || gameType.IsSolo || gameType.IsAbondance)
                {
                    if (declaring)
                    {
                        this.Value = winning ? 15 : -15;
                    }
                    else
                    {
                        this.Value = winners.Count() == 0 ? 5 : -5;
                    }

                    if (gameType.IsSolo)
                    {
                        this.Value = this.Value * 2;
                    }

                    if (gameType.IsSoloSlim)
                    {
                        this.Value = this.Value * 3;
                    }
                }


            }
            else
            {
                this.RemoveValue();
            }



        }
    }
}
