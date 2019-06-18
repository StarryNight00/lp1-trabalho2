using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class DrawBoard
    {
        public string N;
        public string S;
        public string O;
        public string E;

        private Board board;
        // private Player keyinfo;

        public DrawBoard(Board board)
        {
            this.board = board;
        }

        //render the board
        public void BoardRender()
        {
            Console.Clear();
            //
            for (int y = 0; y < board.Height; y++)
            {
                //
                for (int x = 0; x < board.Width; x++)
                {
                    Console.Write(" ");
                    if (board.Grid[x, y] != null)
                    {
                        if (board.Grid[x, y].MyType == AgentType.human)
                            Console.ForegroundColor = ConsoleColor.Blue;
                        else
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(board.Grid[x, y].ToString());

                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(" . ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
