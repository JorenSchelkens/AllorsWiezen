// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Custom.cs" company="Allors bvba">
//   Copyright 2002-2017 Allors bvba.
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

namespace Commands
{

    using McMaster.Extensions.CommandLineUtils;

    [Command(Name = "chat", Description = "Chat cli")]
    [Subcommand(
       typeof(List),
       typeof(Statistics),
       typeof(Add)
        )]
    public class ChatCommand
    {
        [Option(Description = "Chat Box")]
        public string Box { get; }

        public Commands Parent { get; set; }
    }
}