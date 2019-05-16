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
            Console.WriteLine("Humanos VS Zombies");
            Console.ReadKey();
            MainMenu();
        }

        //Menu
        private void MainMenu() {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Start");
            Console.WriteLine("2 - Credits");
            Console.WriteLine("3 - Quit");

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
            //Go to GameLoop
        }

        //Method for Credits
        private void Credits()
        {
            Console.Clear();
            Console.WriteLine("PROJECT BY:");
            Console.WriteLine("Diana Noia a21703004");
            Console.WriteLine("Sara Gama a21705494");
            Console.WriteLine("Catarina Matias a21801693");
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
