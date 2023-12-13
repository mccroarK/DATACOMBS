using System;
using System.Windows.Forms;
using DATA_UI;

namespace DATA_ASSETS
{
    public class View : Command
    {
        public View()
        {
            NAME = "View";
            KEYS = new string[] { "view", "stats", "menu", "list" };
        }

        public override void Execute(Player player, string[] options)
        {
            switch (options.Length)
            {
                // No option
                case 0:
                    // Display player stats
                    Application.Run(new ActorForm(player.Info()));
                    break;

                // Multiple options
                default:
                    foreach (string option in options)
                    {
                        switch (option)
                        {
                            // View missed questions
                            case "missed":
                                //Application.Run()
                                break;

                            // View stats of room actors
                            case "room":
                                Application.Run(new RoomForm(player.ROOM.Info()));
                                break;

                            // View own stats
                            case "self":
                            case "":
                                Application.Run(new ActorForm(player.Info()));
                                break;

                            // View help
                            default:
                                Console.WriteLine("Options: self, room, missed");
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
