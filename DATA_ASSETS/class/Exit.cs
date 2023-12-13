using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Exit : Thing, IExit
    {
        // Properties
        public string DIRECTION { get; set; }
        public Question QUESTION { get; set; }

        // Constructors
        public Exit() : base()
        {
            DIRECTION = "???";
            QUESTION = new Question("1 + 1", "2");
        }

        public Exit(int id, string name, string direction, string prompt, string answer) : base(id, name)
        {
            DIRECTION = direction;
            QUESTION = new Question(prompt, answer);
        }

        // Methods
        public override string Info()
        {
            // Get info string
            return $"Exit {DIRECTION} ({QUESTION.PROMPT})";
        }

        public void OnInteract(Player player)
        {
            switch (DIRECTION)
            {
                // North
                case "north":
                    break;

                // South
                case "south":
                    break;

                // East
                case "east":
                    break;

                // West
                case "west":
                    break;

                // Random Room
                case "random":
                    break;

                // Portal
                default:
                    // Create new room
                    Room room = new Room();

                    // Randomize room
                    // TODO: Implement

                    // Place player in new room
                    player.EnterRoom(room);
                    break;
            }
        }
    }
}
