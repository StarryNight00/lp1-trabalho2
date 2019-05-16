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
            Console.WriteLine("Start");
            Console.WriteLine("Quit");
            Console.WriteLine("Credits");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("START");
                    break;
                case 2:
                    Console.WriteLine("QUIT");
                    break;
                case 3:
                    Console.WriteLine("CREDITS");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        }

        private void Start()
        {

        }

        private void Quit()
        {

        }

        private void Credits()
        {
            Console.WriteLine("PROJECT BY:");
            Console.WriteLine("Diana");
            Console.WriteLine("Sara");
            Console.WriteLine("Catarina");
        }

    }
}
