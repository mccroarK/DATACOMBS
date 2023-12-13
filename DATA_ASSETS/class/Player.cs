using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DATA_ASSETS
{
    public class Player : Actor
    {
        // Properties
        public Room ROOM { get; set; }                                      // Current Room
        public List<Item> INVENTORY { get; set; } = new List<Item>();             // Inventory
        public List<Question> MISSED { get; set; } = new List<Question>();  // Missed Questions

        // Constructors
        public Player() : base()
        {

        }

        public Player (int id, string name): base(id, name, 20)
        {

        }

        // Methods
        public override string Info()
        {
            // Basic stats
            string info = $"{NAME};{HP}";

            // For every item in inventory
            foreach (Item item in INVENTORY)
            {
                // If item is not last
                if (item != INVENTORY[INVENTORY.Count - 1])
                {
                    info += item.Info() + "|";
                }

                // If item is last
                else
                {
                    info += item.Info() + ";" ;
                }
            }

            // Return info string
            return info;
        }

        public override void Turn()
        {
            // Get player command input
            GetInput();
        }

        public override void CheckHP()
        {
            // If HP less than or equal to 0
            if (HP.VAL <= HP.MIN)
            {
                // Set HP to 0
                HP.VAL = HP.MIN;

                // Game over
                GameManager.EndGame();
            }
        }

        public void EnterRoom(Room room)
        {
            // If current room is not null
            if (ROOM != null)
            {
                // For every interactable still in the room
                foreach (IInteractable thing in ROOM.THINGS.OfType<IInteractable>())
                {
                    // Add the question to the missed list
                    MISSED.Add(thing.QUESTION);
                }

                // Remove player from current room
                room.THINGS.Remove(this);
            }

            // Add player to current room
            ROOM = room;
            ROOM.THINGS.Add(this);

            // Clear old room text
            Console.Clear();

            // Display move string
            GameManager.Display($"You moved to room {ROOM.NAME}");
        }

        public void Attack(Actor actor)
        {
            // TODO: Apply weapon damage
            actor.HP.VAL -= 1;

            // Display attack string
            GameManager.Display($"You attacked {actor.NAME}.");
        }

        public void PickUp(Item item)
        {
            // Remove item from current room
            ROOM.THINGS.Remove(item);

            // Add item to current inventory
            INVENTORY.Add(item);
        }

        void GetInput()
        {
            // Ask for input
            Console.Write(">> ");

            // Get player input
            string input = Console.ReadLine().ToLower();

            // Split input string by semicolons to get commands and parameters
            string[] commandlines = input.Split(';');

            // For every inputted command
            foreach (string line in commandlines)
            {
                // Split input string
                List<string> tokens = line.Split(' ').ToList();

                // If first token is an empty string and nothing is behind it
                if (tokens[0] == string.Empty && tokens.Count > 1)
                {
                    // Remove first element
                    tokens.RemoveAt(0);
                }

                // Get command from first token
                var comlist = from com in WorldObjects.COMMANDS
                              where com.KEYS.Contains(tokens.ToArray()[0])
                              select com;

                // If command list is not empty
                if (comlist.Any())
                {
                    // Get first command typed and options
                    Command command = comlist.First();
                    string[] options = tokens.Skip(1).ToArray();

                    // If option list is not empty
                    if (options.Any())
                    {
                        Console.WriteLine(command.NAME);
                        Console.ReadLine();
                        // Execute command from tokens after command
                        command.Execute(this, options);
                    }
                }
            }
        }
    }
}
