using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    internal class Answer : Command
    {
        public Answer()
        {
            NAME = "Answer";
            KEYS = new string[] { "answer", "interact", "=" };
        }

        public override void Execute(Player player, string option)
        {
            // For every interactable thing in the current room
            foreach(IInteractable thing in player.ROOM.THINGS.OfType<IInteractable>())
            {
                // If the interactable answer matches the player answer
                if (thing.QUESTION.ANSWER == option)
                {
                    // Activate thing
                    thing.OnInteract(player);
                }
            }
        }
    }
}
