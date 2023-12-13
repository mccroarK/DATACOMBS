using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public abstract class Command : ICommand
    {
        // Properties
        public string NAME { get; set; }
        public string[] KEYS { get; set; }

        // Methods
        public string Info()
        {
            // Info string
            string info = $"{NAME}\nAliases: ";

            // Add aliases to info string
            foreach(string alias in KEYS)
            {
                // If alias is not last
                if (alias != KEYS[KEYS.Length - 1])
                {
                    info += $"{alias}, ";
                }

                // If item is last
                else
                {
                    info += $"{alias}";
                }
            }

            // Return info string
            return info;
        }
        public abstract void Execute(Player player, string[] options);
    }
}
