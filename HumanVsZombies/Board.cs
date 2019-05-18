﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Board
    {
        //variaveis. recebe alt e larg
        public int Height { get; private set; }
        public int Width { get; private set; }
        private int z, h, Z, H, t;


        //Board construct
        public Board()
        {
            
        }


        private void GameInit()
        {
            // string array that receives the arguments in main
            string[] values = Program.arguments;

            for (int i = 0; i < values.Length; i++)
            {
                switch (values[i])
                {
                    case "-x":
                        Width = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-y":
                        Height = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-z":
                        z = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-h":
                        h = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-Z":
                        Z = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-H":
                        H = Convert.ToInt32(values[i] + 1);
                        break;
                    case "-t":
                        t = Convert.ToInt32(values[i] + 1);
                        break;
                }
            }

        }
        
        


        

        


    }
}
