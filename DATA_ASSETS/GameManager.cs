﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DATA_ASSETS
{
    // I'm dumb and I can't get singletons to work
    public static class GameManager
    {
        public static bool Running { get; set; }
        public static Player player { get; set; }
        public static Settings settings { get; set; }
        public static void Run()
        {
            SetUp();

            // Game loop
            while (Running)
            {
                // Get every actor in the room
                var actors = from actor in player.ROOM.THINGS.OfType<Actor>()
                             select actor;

                // Actor turns
                foreach (Actor actor in actors)
                {
                    actor.Turn();

                    // Update every enemy after a turn
                    foreach (Actor actor2 in actors)
                    {
                        actor2.Update();
                    }
                }
            }
        }

        static Player MakePlayer()
        {
            // Enter player name
            bool blockname = false;
            string name = string.Empty;

            do
            {
                // Clear the console
                Console.Clear();

                // Print prompt if name was entered incorrectly
                if (blockname == true)
                {
                    Console.WriteLine("Please only input letters and digits");
                }

                // Set blockname to false
                blockname = false;

                // Prompt for name
                Console.Write("Enter your name: ");

                // Get inputted name
                name = Console.ReadLine();

                // loop through every letter in the inputted name
                foreach(char letter in name)
                {
                    // If there is a special character
                    if (!char.IsLetterOrDigit(letter))
                    {
                        // Block the name
                        blockname = true;
                    }
                }

            // While the name is blocked
            } while (blockname);

            // Make the player with the name
            Player player = new Player(0, name);

            // Return player
            return player;
        }

        static void SetUp()
        {
            // Load game objects
            WorldObjects.Load();

            // Add settings
            settings = new Settings();

            // Get player name
            player = MakePlayer();

            // Create a player
            player.EnterRoom(new Room());

            // Set game to running
            Running = true;
        }

        public static void EndGame()
        {
            Display("Game Over");
            Running = false;

            Console.WriteLine("[CLOSE]");
            Console.ReadLine();
        }

        public static void Display(string message)
        {
            foreach(char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(settings.TYPE);
            }
            Console.WriteLine();
        }
    }
}
