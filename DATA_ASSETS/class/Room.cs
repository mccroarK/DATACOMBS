using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Room : Thing
    {
        // Properties
        public List<Thing> THINGS { get; set; } = new List<Thing>();

        // Constructors
        public Room() : base(0, "???")
        {
            // TEMP add random exit
            THINGS.Add(new Exit());
        }

        // Methods
        public override string Info()
        {
            // Create info variable
            string info = "";

            // Get info list of all nonplayer actors
            var infolist = from a in THINGS
                           where a.GetType() != typeof(Player)
                           select a.Info();

            // Combine info list and separate with semicolons
            foreach (var line in infolist)
            {
                // If item is not last in list
                if (line != infolist.ToList()[infolist.Count() - 1])
                {
                    info += line + ";";
                }

                // If item is last in list
                else
                {
                    info += line;
                }
            }

            // Return info string
            return info;
        }
    }
}
