//------------------------------------------------------------------------------------------------- 
// <copyright file="DemoTests.cs" company="Allors bvba">
// Copyright 2002-2009 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>Defines the MediaTests type.</summary>
//-------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using Allors.Meta;
    using System.Linq;
    using Xunit;

    public class ScoreTest : DomainTest
    {
        private Scoreboard scoreboard;
        private Person player1;
        private Person player2;
        private Person player3;
        private Person player4;

        private GameTypes GameTypes;

        public ScoreTest()
        {
            var people = new People(this.Session);

            this.player1 = people.FindBy(M.Person.UserName, "speler1");
            this.player2 = people.FindBy(M.Person.UserName, "speler2");
            this.player3 = people.FindBy(M.Person.UserName, "speler3");
            this.player4 = people.FindBy(M.Person.UserName, "speler4");

            this.scoreboard = new ScoreboardBuilder(this.Session)
                .WithPlayer(player1)
                .WithPlayer(player2)
                .WithPlayer(player3)
                .WithPlayer(player4)
                .Build();

            this.GameTypes = new GameTypes(this.Session);

            this.Session.Derive();
        }

        [Fact]
        public void TestSync()
        {
            //Arrange
            var game = new GameBuilder(this.Session).Build();

            //Act
            scoreboard.AddGame(game);
            this.Session.Derive();

            //Assert
            Assert.Equal(4, game.Scores.Count);

        }

        [Fact]
        public void TestMiserieWithoutWinners()
        {
            //Arrange
            var game = new GameBuilder(this.Session).Build();
            scoreboard.AddGame(game);

            //Act
            game.GameType = this.GameTypes.Miserie;
            this.Session.Derive();

            //Assert
            Assert.Null(game.Scores.First(v => v.Player == player1).Value);
            Assert.Null(game.Scores.First(v => v.Player == player2).Value);
            Assert.Null(game.Scores.First(v => v.Player == player3).Value);
            Assert.Null(game.Scores.First(v => v.Player == player4).Value);
            Assert.True(this.scoreboard.NulProef());
        }
    }
}