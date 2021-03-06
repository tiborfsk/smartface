using System.Collections;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using SmartFace.Cli.Commands.SubCmdFrom;
using SmartFace.Cli.Common;

namespace SmartFace.Cli.Commands
{
    [Command(Name = "query", Description = "Select entities using Language Integrated Query (LINQ)"),
     Subcommand(typeof(FromWlHits)),
     Subcommand(typeof(FromFaces)),
     Subcommand(typeof(FromScopes)),
     Subcommand(typeof(FromGroupings)),
     Subcommand(typeof(FromIdentities)),
     Subcommand(typeof(FromWatchlists)),
     Subcommand(typeof(FromWlItems)),
    ]
    public class QueryCmd
    {
        protected virtual int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine(Constants.HELP_SPECIFY_SUBCMD);
            return Constants.EXIT_CODE_OK;
        }

        public void Execute(IConsole console, IEnumerable entities)
        {
            foreach (var entity in entities)
            {
                console.WriteLine(JsonConvert.SerializeObject(entity, Formatting.Indented));
            }
        }
    }
}