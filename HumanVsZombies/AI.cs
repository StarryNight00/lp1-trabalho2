namespace HumanVsZombies
{
    /// <summary>
    /// Class AI that controls the game's basic Artificial Intelligence
    /// </summary>
    class AI : Agents
    {
        //Public AI constuctor. Sets a type, Id and coordinates.
        public AI(AgentType type, int id, int posX, int posY) : base(type, id, posX, posY) { }

        /// <summary>
        /// Method that goes through the board and check the movement possibilities.
        /// </summary>
        /// <param name="board">From the Board Class. Has all the Agent related values.</param>
        public void SearchForAgent(Board board)
        {
            bool toroidal = false;
            int move = 1;
            int x = PosX;
            int y = PosY;
            int newX = PosX;
            int newY = PosY;

            //While going through the board, the cycle checks all current
            //positions and available moves, passing the values to the AI Agent
            for (int i = 1; i <= ((board.Width + board.Height)); i++)
            {
                for (int j = 2; j <= 2; j++)
                {
                    if (move == 4)
                        move = 1;
                    else
                        move++;
                    // Direction of the movement
                    for (int block = 1; block <= i; block++)
                    {
                        switch (move)
                        {
                            case 1:
                                newX++;
                                break;
                            case 2:
                                newY++;
                                break;
                            case 3:
                                newX--;
                                break;
                            case 4:
                                newY--;
                                break;
                        }

                        toroidal = Toroidal(ref newX, ref newY, board, toroidal);

                        // If position not empty
                        if (board.Grid[newX, newY] != null)
                        {
                            // If agent diferent from current type
                            if (board.Grid[newX, newY].MyType != MyType)
                            {
                                board.Grid[x, y] = default(Agents);

                                // If current agent human
                                if (MyType == AgentType.human)
                                {
                                    if (toroidal)
                                    {
                                        if (newX < x && newY == y)
                                        {
                                            x++;
                                        }
                                        else if (newX > x && newY == y)
                                        {
                                            x--;
                                        }
                                        else if (newX < x && newY < y)
                                        {
                                            x++;
                                            y++;
                                        }
                                        else if (newX > x && newY < y)
                                        {
                                            x--;
                                            y++;
                                        }
                                        else if (newX < x && newY > y)
                                        {
                                            x++;
                                            y--;
                                        }
                                        else if (newX > x && newY > y)
                                        {
                                            x--;
                                            y--;
                                        }
                                        else if (newX == x && newY < y)
                                        {
                                            y++;
                                        }
                                        else if (newX == x && newY > y)
                                        {
                                            y--;
                                        }
                                    }
                                    else
                                    {
                                        if (newX < x && newY == y)
                                        {
                                            x++;
                                        }
                                        else if (newX > x && newY == y)
                                        {
                                            x--;
                                        }
                                        else if (newX < x && newY < y)
                                        {
                                            x++;
                                            y++;
                                        }
                                        else if (newX > x && newY < y)
                                        {
                                            x--;
                                            y++;
                                        }
                                        else if (newX < x && newY > y)
                                        {
                                            x++;
                                            y--;
                                        }
                                        else if (newX > x && newY > y)
                                        {
                                            x--;
                                            y--;
                                        }
                                        else if (newX == x && newY < y)
                                        {
                                            y++;
                                        }
                                        else if (newX == x && newY > y)
                                        {
                                            y--;
                                        }
                                    }
                                }
                                // If current agent zombie
                                else
                                {
                                    if (toroidal)
                                    {
                                        if (newX < x && newY == y)
                                        {
                                            x++;
                                        }
                                        else if (newX > x && newY == y)
                                        {
                                            x--;
                                        }
                                        else if (newX < x && newY < y)
                                        {
                                            x++;
                                            y++;
                                        }
                                        else if (newX > x && newY < y)
                                        {
                                            x--;
                                            y++;
                                        }
                                        else if (newX < x && newY > y)
                                        {
                                            x++;
                                            y--;
                                        }
                                        else if (newX > x && newY > y)
                                        {
                                            x--;
                                            y--;
                                        }
                                        else if (newX == x && newY < y)
                                        {
                                            y++;
                                        }
                                        else if (newX == x && newY > y)
                                        {
                                            y--;
                                        }
                                    }
                                    else
                                    {
                                        if (newX < x && newY == y)
                                        {
                                            x--;
                                        }
                                        else if (newX > x && newY == y)
                                        {
                                            x++;
                                        }
                                        else if (newX < x && newY < y)
                                        {
                                            x--;
                                            y--;
                                        }
                                        else if (newX > x && newY < y)
                                        {
                                            x++;
                                            y--;
                                        }
                                        else if (newX < x && newY > y)
                                        {
                                            x--;
                                            y++;
                                        }
                                        else if (newX > x && newY > y)
                                        {
                                            x++;
                                            y++;
                                        }
                                        else if (newX == x && newY < y)
                                        {
                                            y--;
                                        }
                                        else if (newX == x && newY > y)
                                        {
                                            y++;
                                        }
                                    }
                                }

                                Toroidal(ref x, ref y, board, toroidal);

                                //Checks if the Agent is a Zombie and if
                                //the nearby Agent is Human, allowing to infect.
                                if (board.Grid[x, y] != null &&
                                        MyType == AgentType.zombie &&
                                        board.Grid[x, y].MyType == AgentType.human)
                                {
                                    Infection(board.Grid[newX, newY], board);
                                }
                                board.Grid[x, y] = this;

                                PosX = x;
                                PosY = y;
                                return;
                            }
                        }

                    }

                }
            }
        }

        /// <summary>
        /// Method ToString to show the 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string temp;
            if (MyType == AgentType.human)
                temp = "\u0040";
            else
                temp = "\u0298";
            return string.Format(temp + $"{Id:D2}");
        }
    }
}