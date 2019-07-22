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
    using Allors.Domain;
    using Allors.Services;
    using Humanizer;
    using McMaster.Extensions.CommandLineUtils;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Linq;

    [Command(Description = "Add a chat message")]
    public class List
    {
        [Option(Description = "Message Text")]
        public string Message { get; }

        private readonly IDatabaseService databaseService;

        private readonly ILogger<Custom> logger;

        public List(IDatabaseService databaseService, ILogger<Custom> logger)
        {
            this.databaseService = databaseService;
            this.logger = logger;
        }

        private ChatCommand Parent { get; set; }

        public int OnExecute(CommandLineApplication app)
        {
            using (var session = this.databaseService.Database.CreateSession())
            {
                var chat = new Chats(session)
                    .Extent()
                    .FirstOrDefault(v => v.Name.Equals(this.Parent.Box));

                Console.Write(chat.Messages.Count + " messages, by ");

                var userNamesWithCommas = string.Join(", ", chat.Participants.Select(v => v.UserName));

                Console.WriteLine(userNamesWithCommas);

                foreach (Message message in chat.Messages)
                {
                    Console.WriteLine($"{message.Author.UserName} [{message.Date.Humanize()}]: {message.Text}");
                }
            }

            return ExitCode.Success;
        }
    }
}