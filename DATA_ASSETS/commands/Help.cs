using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Help : Command
    {
        public Help()
        {
            NAME = "Help";
            KEYS = new string[] { "help" };
        }

        public override void Execute(Player player, string option)
        {
            // If player does not input an option
            if (option == string.Empty)
            {
                // For every available command
                foreach(Command command in WorldObjects.COMMANDS)
                {
                    // Print command and aliases
                    Console.WriteLine($"{command.Info()}\n");
                }
            }

            // If player inputs a command keystring
            else
            {
                // For every available command
                foreach (Command command in WorldObjects.COMMANDS)
                {
                    // If command key is called
                    if (command.KEYS.Contains(option))
                    {
                        // Print command, aliases, and options
                        Console.WriteLine($"{command.Info()}\n");
                        // TODO: Print command options
                    }
                }
            }
        }
    }
}
