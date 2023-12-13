using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Quit : Command
    {
        public Quit()
        {
            NAME = "Quit";
            KEYS = new string[] { "quit", "exit" };
        }

        public override void Execute(Player player, string[] options)
        {
            // TODO: Make messages class and make goofy random goodbye messages
            GameManager.Display("You left the game.");
            GameManager.Running = false;
        }
    }
}
