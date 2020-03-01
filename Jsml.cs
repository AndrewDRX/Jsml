using System;

using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.CommandLineUtils;

using Jsml.Loadables;
using Jsml.Server;

namespace Jsml
{
    public class Jsml
    {
        public static void Main(string[] args)
        {
            ProcessArguments(args: args);
        }
        
        private static void ProcessArguments(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "Jsml";
            app.Description = "A JSON based web framework. No HTML or CSS needed.";
            app.HelpOption(template: "-?|-h|--help");
            app.OnExecute(invoke: () => {
                app.ShowHelp();
                return 0;
            });
            app.Command(
                name: "build",
                configuration: (CommandLineApplication command) => {
                    command.Description = "Build Jsml project.";
                    command.HelpOption(template: "-?|-h|--help");
                    var path = command.Option(
                        template: "-p|--path",
                        description: "Path to project.",
                        optionType: CommandOptionType.SingleValue
                    );
                    command.OnExecute(invoke: () => {
                        if (path.HasValue()) {
                            Console.WriteLine("Build has finished.");
                        }
                        else {
                            command.ShowHelp();
                        }
                        return 0;
                    });
                }
            );
            app.Command(
                name: "serve",
                configuration: (CommandLineApplication command) => {
                    command.Description = "Serve Jsml project.";
                    command.HelpOption(template: "-?|-h|--help");
                    var path = command.Option(
                        template: "-p|--path",
                        description: "Path to project.",
                        optionType: CommandOptionType.SingleValue
                    );
                    command.OnExecute(invoke: () => {
                        JsmlWebServer
                            .Create(root: new LoadableElement(path: path.Value() ?? "./"))
                            .Run();
                        return 0;
                    });
                }
            );
            app.Execute(args: args);
        }
    }
}
