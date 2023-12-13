using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    internal class Input : Command
    {
        public Input()
        {
            NAME = "Input";
            KEYS = new string[] { "input", "answer", "interact", "=" };
        }

        public override void Execute(Player player, string[] options)
        {
            switch (options.Length)
            {
                // No option
                case 0:
                    GameManager.Display("Enter an option");
                    break;

                // Multiple options
                default:
                    foreach (string option in options)
                    {
                        // For every interactable thing in the current room
                        foreach (IInteractable thing in player.ROOM.THINGS.OfType<IInteractable>())
                        {
                            // If the interactable answer matches the player answer
                            if (thing.QUESTION.ANSWER == option)
                            {
                                // Activate thing
                                thing.OnInteract(player);
                            }
                        }
                    }
                    break;
            }
        }
    }
}
