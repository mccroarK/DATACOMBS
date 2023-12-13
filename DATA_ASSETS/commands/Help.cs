using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DATA_ASSETS
{
    public class Help : Command
    {
        public Help()
        {
            NAME = "Help";
            KEYS = new string[] { "help" };
        }

        public override void Execute(Player player, string[] options)
        {
            switch (options.Length)
            {
                // No options
                case 0:
                    // For every available command
                    foreach (Command command in WorldObjects.COMMANDS)
                    {
                        // Print command and aliases
                        Console.WriteLine($"{command.Info()}\n");
                    }
                    break;

                // Multiple options
                default:
                    // For every option inputted
                    foreach (string option in options)
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
                    break;
            }
        }
    }
}
