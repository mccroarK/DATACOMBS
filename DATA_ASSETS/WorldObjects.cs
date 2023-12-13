using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DATA_ASSETS
{
    public static class WorldObjects
    {
        // Properties
        public static List<Stat> _worldStats = new List<Stat>();
        public static List<Command> _worldCommands = new List<Command>();
        public static void Load()
        {
            LoadStats();
            LoadCommands();
        }

        private static void LoadStats()
        {
            // using stats file
            using (StreamReader reader = File.OpenText(@"..\..\..\DATA_ASSETS\csv\stats.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    _worldStats.Add(new Stat(int.Parse(tokens[0]), tokens[1]));
                }
            }
        }

        private static void LoadCommands()
        {
            // Add commands
            _worldCommands.Add(new View());
            _worldCommands.Add(new Answer());
            _worldCommands.Add(new Quit());
            _worldCommands.Add(new Help());
        }
    }
}
