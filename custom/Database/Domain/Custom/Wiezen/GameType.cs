using System;
using System.Collections.Generic;

namespace Allors.Domain
{
    public partial class GameTypes
    {
        public static readonly Guid SoloSlimId = new Guid("7a369e7f-4eec-4023-8174-a52cab4a4d79");
        public static readonly Guid MiserieId = new Guid("b24d304d-6f5b-4f21-b6cd-3fac42dbf87d");

        private UniquelyIdentifiableSticky<GameType> cache;

        public GameType SoloSlim => this.Cache[SoloSlimId];

        public GameType Miserie => this.Cache[MiserieId];

        private UniquelyIdentifiableSticky<GameType> Cache => this.cache ?? (this.cache = new UniquelyIdentifiableSticky<GameType>(this.Session));

        protected override void CustomSetup(Setup setup)
        {

            new GameTypeBuilder(this.Session)
                .WithName("Solo slim")
                .WithUniqueId(SoloSlimId)
                .WithIsActive(true)
                .Build();

            new GameTypeBuilder(this.Session)
                .WithName("Miserie")
                .WithUniqueId(MiserieId)
                .WithIsActive(true)
                .Build();
        }
    }
}
