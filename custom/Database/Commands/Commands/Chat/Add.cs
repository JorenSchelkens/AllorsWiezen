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
    using Allors;
    using Allors.Domain;
    using Allors.Services;

    using McMaster.Extensions.CommandLineUtils;
    using Microsoft.Extensions.Logging;
    using System.Linq;

    [Command(Description = "Add a chat message")]
    public class Add
    {
        [Argument(0)]
        public string[] Message { get; }

        private readonly IDatabaseService databaseService;

        private readonly ILogger<Custom> logger;

        public Add(IDatabaseService databaseService, ILogger<Custom> logger)
        {
            this.databaseService = databaseService;
            this.logger = logger;
        }

        private ChatCommand Parent { get; set; }

        public int OnExecute(CommandLineApplication app)
        {
            using (var session = this.databaseService.Database.CreateSession())
            {
                var user = new Users(session).GetUser(this.Parent.Parent.User) as Person;

                var chat = new Chats(session)
                    .Extent()
                    .FirstOrDefault(v => v.Name.Equals(this.Parent.Box));

                var message = new MessageBuilder(session)
                    .WithAuthor(user)
                    .WithText(string.Join(" ", this.Message))
                    .Build();

                chat.AddMessage(message);

                session.Derive();
                session.Commit();

                this.logger.LogInformation("Message Added");
            }

            return ExitCode.Success;
        }
    }
}