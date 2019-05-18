using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Menu
    {
        // UNICODES HUMANO ☻ \u263B ZOMBIE ◌ \u25CC

        //Intro
        public void Intro() {
            Console.Clear();
            // x, y human
            Console.SetCursorPosition(44,2);
            Console.WriteLine("\u263B ");
            Console.SetCursorPosition(37, 3);
            Console.WriteLine("\u263B ");
            Console.SetCursorPosition(32, 4);
            Console.WriteLine("\u263B ");
            Console.SetCursorPosition(37, 5);
            Console.WriteLine("\u263B ");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("\u263B ");
            // x, y -> zombie
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("\u25CC ");
            Console.SetCursorPosition(65, 3);
            Console.WriteLine("\u25CC ");
            Console.SetCursorPosition(75, 4);
            Console.WriteLine("\u25CC ");
            Console.SetCursorPosition(57, 5);
            Console.WriteLine("\u25CC ");
            Console.SetCursorPosition(67, 6);
            Console.WriteLine("\u25CC ");
            // Game intro
            Console.SetCursorPosition(47, 4);
            Console.WriteLine("\u263B Humanos Vs Zombies \u25CC");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine(" Press any key ");
            Console.ReadKey();
            MainMenu();
        }

        // Menu
        private void MainMenu() {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tHumanos Vs Zombies ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     \u2021 MENU \u2021 ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     1 Start    ");
            Console.WriteLine("\t\t\t\t\t\t     2 Credits  ");
            Console.WriteLine("\t\t\t\t\t\t     3 Quit     ");

            Console.WriteLine();

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Start();
                    break;
                case 2:
                    Credits();
                    break;
                case 3:
                    Quit();
                    break;
                default:
                    Console.WriteLine(" Invalid input ");
                    break;
            }

            Console.ReadLine();
        }

        //Method to start game
        private void Start()
        {
            Game gameLoop = new Game();

            //Go to Game class
            gameLoop.StartGame();

        }

        //Method for Credits
        private void Credits()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t       \u2021 CREDITS \u2021 ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t    \u2666  Catarina Matias nº21801693");
            Console.WriteLine("\t\t\t\t\t    \u2666  Diana Noia      nº21703004");
            Console.WriteLine("\t\t\t\t\t    \u2666  Sara Gama       nº21705494");
            // NOVO
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     Press any key ");
            Console.ReadKey();
            MainMenu();
        }

        //Method to quit game
        private void Quit()
        {
            Environment.Exit(0);
        }

    }
}
