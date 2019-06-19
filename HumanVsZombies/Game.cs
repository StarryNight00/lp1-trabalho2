using System;

namespace HumanVsZombies
{
    /// <summary>
    /// Class that initializes the gameloop and controls game related variables.
    /// </summary>
    class Game
    {
        //Creating the game's board controling variables through the correspondent class.
        private Board gameboard;
        private DrawBoard renderGame;

        //Game state check variables
        private bool winCondition;
        private string input;
        private int currentTurn;


        /// <summary>
        /// Calls on DrawGame and initializes the Board
        /// </summary>
        public void StartGame()
        {
            Console.Clear();

            //...
            gameboard = new Board();
            renderGame = new DrawBoard(gameboard);

            gameboard.GameInit();
            gameboard.InitializeAgents();
            gameboard.InitializeGrid();

            renderGame.BoardRender();

            currentTurn = 1;
            winCondition = false;

            GameLoop();
        }

        /// <summary>
        /// Gameloop control method. Controls the game's state with each cycle.
        /// </summary>
        public void GameLoop()
        {
            do
            {
                int i = 0;

                //Goes through all the Agents in AgentList with each turn
                //and prints the current state.
                foreach (Agents a in gameboard.AgentsList)
                {
                    renderGame.BoardRender();
                    renderGame.Legend(gameboard.AgentsList[i]);

                    if (a != null && (a is AI))
                    {
                        (a as AI).SearchForAgent(gameboard);
                        Console.ReadKey();
                    }
                    else if (a != null && (a is Player))
                    {
                        (a as Player).MovePlayer(gameboard);
                    }

                    i++;
                }
                currentTurn++;
            }

            // Checks if win condition is false
            while (!winCondition && currentTurn < gameboard.Turn);
            Console.ReadLine();
        }
    }
}