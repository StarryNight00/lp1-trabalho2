using System;

namespace HumanVsZombies
{
    class DrawBoard
    {
        //Set of strings to draw the Map's direction text
        public string N;
        public string S;
        public string O;
        public string E;

        private Board board;

        /// <summary>
        /// DrawBoard constructor. Receives a board to draw.
        /// </summary>
        /// <param name="board">Game's board.</param>
        public DrawBoard(Board board)
        {
            this.board = board;
        }

        /// <summary>
        /// Method that renders the board according to each agent's information.
        /// </summary>
        public void BoardRender()
        {
            Console.Clear();
            //Cycle that checks for each AgentType in board's Agents and
            //renders their position
            for (int y = 0; y < board.Height; y++)
            {
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

        /// <summary>
        /// Direction text on the side of the board in game.
        /// </summary>
        /// <param name="a">Agent type variable.</param>
        public void Legend(Agents a)
        {
            int x = a.PosX;
            int y = a.PosY;

            if (x >= board.Width)
            {
                x = 0;
            }
            else if (x < 0)
            {
                x = board.Width - 1;
            }
            if (y >= board.Height)
            {
                y = 0;
            }
            else if (y < 0)
            {
                y = board.Height - 1;
            }

            if ((y - 1) < 0)
            {
                y = board.Height;
            }
            if (board.Grid[x, y - 1] == null)
            {
                N = "Empty";
            }
            else
            {
                N = board.Grid[x, y - 1].ToString();
            }
            
            y = a.PosY;

            if ((y + 1) >= board.Height)
            {
                y = -1;
            }
            if (board.Grid[x, y + 1] == null)
            {
                S = "Empty";
            }
            else
            {
                S = board.Grid[x, y + 1].ToString();
            }
            y = a.PosY;

            if ((x - 1) < 0)
            {
                x = board.Width;
            }
            if (board.Grid[x - 1, y] == null)
            {
                O = "Empty";
            }
            else
            {
                O = board.Grid[x - 1, y].ToString();
            }
            x = a.PosX;

            if ((x + 1) >= board.Height)
            {
                x = -1;
            }
            if (board.Grid[x + 1, y] == null)
            {
                E = "Empty";
            }
            else
            {
                E = board.Grid[x + 1, y].ToString();
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



            Console.SetCursorPosition(board.Width * 4 + 5, 9);
            Console.Write(" Automatico -> @ - humano | ʘ - zombie ");
            Console.SetCursorPosition(board.Width * 4 + 5, 10);
            Console.Write(" Player ->  ☻ - Humano | ◌ - Zombie ");

            Console.SetCursorPosition(board.Width * 4 + 5, 13);
            Console.Write($"* Próximo a jogar: {a.ToString()} ");
            Console.SetCursorPosition(board.Width * 4 + 5, 14);
            Console.Write($"   - A Norte: {N}");
            Console.SetCursorPosition(board.Width * 4 + 5, 15);
            Console.Write($"   - A Sul: {S}");
            Console.SetCursorPosition(board.Width * 4 + 5, 16);
            Console.Write($"   - A Oeste:{O} ");
            Console.SetCursorPosition(board.Width * 4 + 5, 17);
            Console.Write($"   - A Este: {E}");
            Console.SetCursorPosition(board.Width * 4 + 5, 18);
            Console.Write("* Qual o caminho a seguir? > ");
        }
    }
}
