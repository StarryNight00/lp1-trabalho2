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
        //draw legend
        public void Legend(Agents a)
        {
            if (board.Grid[a.PosX, a.PosY - 1] == null)
            {
                N = "Empty";
            }
            else
            {
                N = board.Grid[a.PosX, a.PosY - 1].ToString();
            }

            if (board.Grid[a.PosX, a.PosY + 1] == null)
            {
                S = "Empty";
            }
            else
            {
                S = board.Grid[a.PosX, a.PosY + 1].ToString();
            }

            if (board.Grid[a.PosX - 1, a.PosY] == null)
            {
                O = "Empty";
            }
            else
            {
                O = board.Grid[a.PosX - 1, a.PosY].ToString();
            }

            if (board.Grid[a.PosX + 1, a.PosY] == null)
            {
                E = "Empty";
            }
            else
            {
                E = board.Grid[a.PosX + 1, a.PosY].ToString();
            }

            Console.SetCursorPosition(board.Width * 4 + 8, 1);
            Console.Write("N");
            Console.SetCursorPosition(board.Width * 4 + 8, 2);
            Console.Write("|");
            Console.SetCursorPosition(board.Width * 4 + 5, 3);
            Console.Write("O--+--E");
            Console.SetCursorPosition(board.Width * 4 + 8, 4);
            Console.Write("|");
            Console.SetCursorPosition(board.Width * 4 + 8, 5);
            Console.Write("S");

            Console.SetCursorPosition(board.Width * 4 + 5, 13);
            Console.Write($"* Próximo a jogar: {a.ToString()} ");
            Console.SetCursorPosition(board.Width * 4 + 5, 14);
            Console.Write($"   - A Norte: {board.Grid[a.PosX, a.PosY - 1]}");
            Console.SetCursorPosition(board.Width * 4 + 5, 15);
            Console.Write($"   - A Sul: {board.Grid[a.PosX, a.PosY + 1]}");
            Console.SetCursorPosition(board.Width * 4 + 5, 16);
            Console.Write($"   - A Oeste:{board.Grid[a.PosX - 1, a.PosY]} ");
            Console.SetCursorPosition(board.Width * 4 + 5, 17);
            Console.Write($"   - A Este: {board.Grid[a.PosX + 1, a.PosY]}");
            Console.SetCursorPosition(board.Width * 4 + 5, 18);
            Console.Write("* Qual o caminho a seguir? > ");
        }
    }
}
