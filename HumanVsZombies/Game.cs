using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Game
    {
        //Calls DrawGame
        public void StartGame()
        {
            Console.Clear();

            //...
            Board gameboard = new Board();
            DrawBoard renderGame = new DrawBoard();

            renderGame.BoardRender(gameboard);

            Console.ReadKey();
        }
    }
}
