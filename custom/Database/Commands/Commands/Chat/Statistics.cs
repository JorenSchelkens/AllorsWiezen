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

using Allors;
using Allors.Domain;
using Allors.Services;

using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Humanizer;

namespace Commands
{
    [Command(Description = "Add a chat message")]
    public class Statistics
    {
        [Option(Description = "Message Text")]
        public string Message { get; }
        
        private readonly IDatabaseService databaseService;

        private readonly ILogger<Custom> logger;

        public Statistics(IDatabaseService databaseService, ILogger<Custom> logger)
        {
            this.databaseService = databaseService;
            this.logger = logger;
        }

        private ChatCommand Parent { get; set; }

        public int OnExecute(CommandLineApplication app)
        {
            using (var session = this.databaseService.Database.CreateSession())
            {
                var chats = new Chats(session)
                    .Extent();

                foreach (Chat chat in chats)
                {
                    Console.WriteLine($"Statistics for: {chat.Name}");

                    foreach(Statistic statistic in chat.Statistics)
                    {
                        Console.WriteLine($"{statistic.Participant.UserName}: {statistic.MessageCount} messages, {statistic.WordCount} words");
                    }

                    Console.WriteLine();
                }
            }

            return ExitCode.Success;
        }
    }
}