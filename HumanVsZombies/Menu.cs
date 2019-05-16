using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Menu
    {
        //Intro
        public void Intro() {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tHumanos Vs Zombies ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t  Press any key ");
            Console.ReadKey();
            MainMenu();
        }

        //Menu
        private void MainMenu() {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tHumanos Vs Zombies ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t------ MENU ------");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     1 - Start");
            Console.WriteLine("\t\t\t\t\t\t     2 - Credits");
            Console.WriteLine("\t\t\t\t\t\t     3 - Quit");

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
                    Console.WriteLine("Invalid input.");
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
            Console.WriteLine("\t\t\t\t\t\t------ CREDITS ------ ");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t      Catarina Matias nº21801693");
            Console.WriteLine("\t\t\t\t\t      Diana Noia      nº21703004");
            Console.WriteLine("\t\t\t\t\t      Sara Gama       nº21705494");
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
