using System;
using System.Text;

namespace HumanVsZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Instancia classe Menu
            Menu menu = new Menu();

            menu.Intro();


        }
    }
}
