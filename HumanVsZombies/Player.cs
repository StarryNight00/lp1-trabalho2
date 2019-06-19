using System;

namespace HumanVsZombies
{
    /// <summary>
    /// Class Player. Controls all of the player controled agents values and
    /// console player inputs.
    /// </summary>
    class Player : Agents
    {
        //Public Player constuctor. Sets a type, Id and coordinates.
        public Player(AgentType type, int id, int posX, int posY) : base(type, id, posX, posY) { }

        /// <summary>
        /// Method that controls the player's input and sets the new coordinate values.
        /// </summary>
        /// <param name="board">Current game's board.</param>
        public void MovePlayer(Board board)
        {
            int newX = PosX;
            int newY = PosY;

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();

            //Switch case that checks the input and chages the
            //coordinate's value accordingly.
            switch (keyInfo.Key)
            {
                // diagonal left baixo
                case ConsoleKey.NumPad1:
                    newX--;
                    newY++;
                    break;
                // down
                case ConsoleKey.NumPad2:
                    newY++;
                    break;
                // diagonal right baixo
                case ConsoleKey.NumPad3:
                    newX++;
                    newY++;
                    break;
                // left
                case ConsoleKey.NumPad4:
                    newX--;
                    break;
                // right
                case ConsoleKey.NumPad6:
                    newX++;
                    break;
                // diagonal left up
                case ConsoleKey.NumPad7:
                    newX--;
                    newY--;
                    break;
                // up
                case ConsoleKey.NumPad8:
                    newY--;
                    break;
                // diagonal right up
                case ConsoleKey.NumPad9:
                    newX++;
                    newY--;
                    break;
            }

            Toroidal(ref newX, ref newY, board, false);

            // 
            if (board.Grid[newX, newY] != null)
            {
                if (MyType == AgentType.zombie && board.Grid[newX, newY].MyType == AgentType.human)
                    Infection(board.Grid[newX, newY], board);
            }
            else
            {
                board.Grid[PosX, PosY] = default(Agents);
                board.Grid[newX, newY] = this;
                PosX = newX;
                PosY = newY;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Create temporary string 
            // Check if its Human or Zombie
            string temp;
            if (MyType == AgentType.human)
                temp = "\u263B";
            else
                temp = "\u25CC";
            return string.Format(temp + $"{Id:D2}");
        }
    }
}