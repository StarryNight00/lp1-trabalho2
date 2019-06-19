using System;
using System.Collections.Generic;

namespace HumanVsZombies
{
    /// <summary>
    /// Class that controls all variables related to the game board
    /// and its initialization.
    /// </summary>
    public class Board
    {
        /*Random Class variable. Allows to call number randomizers*/
        private Random rand;

        /*This Property will permit to save Agents in an Array,
         * save their values and call on them later*/
        public Agents[,] Grid { get; set; }

        /*List of Agents. Permits to shuffle the Agents in order to randomize
         * the Agents' turn order*/
        public List<Agents> AgentsList { get; set; }

        /*Properties and variables that receive all the basic input parameters.
         * The Properties are callable from other classes, allowing to save a
         * value here (not permited anywere else due to the private set) and
         * use it in some other class*/
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Turn { get; private set; }
        public int z, h, Z, H;

        /// <summary>
        /// Constructor for the board class
        /// </summary>
        public Board()
        {
            AgentsList = new List<Agents>();
            rand = new Random();
        }

        /// <summary>
        /// Initializes the list of agents based on the arguments passed
        /// </summary>
        internal void InitializeAgents()
        {
            int currentX = 0, currentY = 0;

            // Adds zombies to list
            for (int i = 0; i < z; i++)
            {
                RandomLocation(ref currentX, ref currentY);

                // Checks if theres any controllable zombies to enter the list
                if (i <= Z)
                    AgentsList.Add(new Player(AgentType.zombie, i, currentX, currentY));
                else
                    AgentsList.Add(new AI(AgentType.zombie, i, currentX, currentY));
            }

            // Adds humans to list
            for (int i = 0; i < h; i++)
            {
                RandomLocation(ref currentX, ref currentY);

                // Checks if theres any controllable humans to enter the list
                if (i <= H)
                    AgentsList.Add(new Player(AgentType.human, i, currentX, currentY));
                else
                    AgentsList.Add(new AI(AgentType.human, i, currentX, currentY));
            }
        }


        /// <summary>
        /// Randomizes the first coordinates of each Agent, checks if said
        /// coordinates already have an Agent, re-randomizing its coordinates,
        /// and placing them on the List of Agents.
        /// </summary>
        /// <param name="currentX">Int value. Current X position of this Agent.</param>
        /// <param name="currentY">Int value. Current Y position of this Agent</param>
        private void RandomLocation(ref int currentX, ref int currentY)
        {
            currentX = rand.Next(0, Width);
            currentY = rand.Next(0, Height);
            foreach (Agents a in AgentsList)
            {
                if (currentX == a.PosX && currentY == a.PosY)
                    RandomLocation(ref currentX, ref currentY);
            }
        }

        /// <summary>
        /// Places the Agent on its coordinates in the Array by reading each 
        /// Agent in AgentList.
        /// </summary>
        internal void InitializeGrid()
        {
            foreach (Agents a in AgentsList)
            {
                Grid[a.PosX, a.PosY] = a;
            }
        }

        /// <summary>
        /// Function that reads the args string to transfer the values.
        /// </summary>
        internal void GameInit()
        {
            //String array that receives the arguments in main
            string[] values = Program.arguments;

            for (int i = 0; i < values.Length; i++)
            {
                switch (values[i])
                {
                    case "-x":
                        Width = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-y":
                        Height = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-z":
                        z = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-h":
                        h = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-Z":
                        Z = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-H":
                        H = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-t":
                        Turn = Convert.ToInt32(values[i + 1]);
                        break;
                }
            }

            // Initialize Grid
            Grid = new Agents[Width, Height];
        }
    }
}
