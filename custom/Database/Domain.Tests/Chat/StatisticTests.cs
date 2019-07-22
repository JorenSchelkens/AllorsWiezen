//------------------------------------------------------------------------------------------------- 
// <copyright file="StatisticTests.cs" company="Allors bvba">
// Copyright 2002-2012 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the SandboxTests type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using Xunit;

    public class StatisticTests : DomainTest
    {
        private readonly Person jos;
        private readonly Person jenny;
        private readonly Chat dev;
        private readonly Chat general;

        public StatisticTests()
        {
            this.jos = new PersonBuilder(this.Session)
                   .WithUserName("jos")
                   .WithFirstName("Jos")
                   .WithLastName("De Smos")
                   .Build();

            this.jenny = new PersonBuilder(this.Session)
                .WithUserName("jenny")
                .WithFirstName("Jenny")
                .WithLastName("De Penny")
                .Build();

            this.dev = new ChatBuilder(this.Session)
                .WithName("dev")
                .WithTitle("Developer's Chat")
                .Build();

            this.general = new ChatBuilder(this.Session)
               .WithName("general")
               .WithTitle("General Chat")
               .Build();
        }

        [Fact]
        public void IntialNoStatistics()
        {
            // arrange
          
            // act
            this.Session.Derive();

            // assert
            Assert.Empty(dev.Statistics);
            Assert.Empty(general.Statistics);
        }


        [Fact]
        public void WhenAddingMessageThenStatisticIsCreated()
        {
            // arrange
            general.AddMessage(
                    new MessageBuilder(this.Session)
                    .WithText("Hallo Jenny")
                    .WithAuthor(jos)
                    .Build());

            // act
            this.Session.Derive();

            // assert
            Assert.Empty(dev.Statistics);
            Assert.Single(general.Statistics);
        }

        [Fact]
        public void WhenAddingAMessageThenMessageCountIsDerived()
        {
            // arrange
          
            // act
            general.AddMessage(
                    new MessageBuilder(this.Session)
                    .WithText("Hallo Jenny")
                    .WithAuthor(jos)
                    .Build());

            this.Session.Derive();

            // assert
            var statistic = general.Statistics.First;
            Assert.Equal(1, statistic.MessageCount);
        }
        
        [Fact]
        public void WhenAddingASecondMessageFromTheSamePersonThenStatisticIsUpdated()
        {
            // arrange
            general.AddMessage(
                    new MessageBuilder(this.Session)
                    .WithText("Hallo Jenny")
                    .WithAuthor(jos)
                    .Build());

            this.Session.Derive();

            // act
            general.AddMessage(
                    new MessageBuilder(this.Session)
                    .WithText("Hallo Jenny 2")
                    .WithAuthor(jos)
                    .Build());

            this.Session.Derive();

            // assert
            var statistic = general.Statistics.First;
            Assert.Equal(2, statistic.MessageCount);
        }
    }
}
