﻿using System;
using System.Text;

namespace HumanVsZombies
{
    /// <summary>
    /// Class to start the menu
    /// </summary>
    class Program
    {
        public static string[] arguments;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            arguments = args;

            //Instancia classe Menu
            Menu menu = new Menu();

            menu.Intro();
        }
    }
}
