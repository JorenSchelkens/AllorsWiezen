using System;
using System.Collections.Generic;

namespace Allors.Domain
{
    public partial class GameType
    {
        public bool IsSoloSlim
        {
            get { return this.UniqueId == GameTypes.SoloSlimId; }
        }

        public bool IsMiserie
        {
            get { return this.UniqueId == GameTypes.MiserieId; }
        }
    }
}
