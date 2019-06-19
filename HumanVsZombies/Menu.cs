using System;

namespace HumanVsZombies
{
    class Menu
    {
        // UNICODES HUMANO ☻ \u263B ZOMBIE ◌ \u25CC | @ \u0040   ʘ\u0298

        /// <summary>
        /// Intro method to print the program's first display
        /// </summary>
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

        /// <summary>
        /// Menu method. Prints the input options and calls the switch case. 
        /// </summary>
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

            //Switch case that controls the menu and calls on the other methods
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

        /// <summary>
        /// Method that calls the Game class in order to start the gameloop.
        /// </summary>
        private void Start()
        {
            Game gameLoop = new Game();

            //Go to Game class
            gameLoop.StartGame();

        }

        /// <summary>
        /// Method that prints the project's credits.
        /// </summary>
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

            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t     Press any key ");
            Console.ReadKey();
            MainMenu();
        }

        /// <summary>
        /// Method that exits the console and closes the program.
        /// </summary>
        private void Quit()
        {
            Environment.Exit(0);
        }

    }
}
