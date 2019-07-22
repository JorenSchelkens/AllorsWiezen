// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Setup.cs" company="Allors bvba">
//   Copyright 2002-2016 Allors bvba.
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
// --------------------------------------------------------------------------------------------------------------------

using Allors.Domain;

namespace Allors
{
    public partial class Setup
    {
        private void CustomOnPrePrepare()
        {
        }

        private void CustomOnPostPrepare()
        {
        }

        private void CustomOnPreSetup()
        {
        }

        private void CustomOnPostSetup()
        {
            if (this.Config.Demo)
            {
                var jos = new PersonBuilder(this.session)
                    .WithUserName("jos")
                    .WithFirstName("Jos")
                    .WithLastName("De Smos")
                    .Build();

                var jenny = new PersonBuilder(this.session)
                    .WithUserName("jenny")
                    .WithFirstName("Jenny")
                    .WithLastName("De Penny")
                    .Build();

                var dev = new ChatBuilder(this.session)
                    .WithName("dev")
                    .WithTitle("Developer's Chat")
                    .Build();

                var general = new ChatBuilder(this.session)
                   .WithName("general")
                   .WithTitle("General Chat")
                   .Build();

                general.AddMessage(
                    new MessageBuilder(session)
                    .WithText("Hallo Jenny")
                    .WithAuthor(jos)
                    .Build());

                general.AddMessage(
                    new MessageBuilder(session)
                    .WithText("Hallo Jos")
                    .WithAuthor(jenny)
                    .Build());
            }
        }
    }
}