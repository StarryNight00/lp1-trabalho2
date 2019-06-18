using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Game
    {
        private Board gameboard;
        private DrawBoard renderGame;

        private bool winCondition;
        private string input;
        private int currentTurn;


        //Calls DrawGame
        public void StartGame()
        {
            Console.Clear();

            //...
            Board gameboard = new Board();
            renderGame = new DrawBoard(gameboard);

            gameboard.GameInit();
            gameboard.InitializeAgents();
            gameboard.InitializeGrid();

            renderGame.BoardRender();

            currentTurn = 1;
            winCondition = false;

            GameLoop();
        }

        public void GameLoop()
        {
            do
            {
                int i = 0;
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

            // checks if win condition is false
            while (!winCondition && currentTurn < gameboard.Turn);
            Console.ReadLine();
        }
    }
}