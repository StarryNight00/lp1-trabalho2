using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class DrawBoard
    {
        //render the board
        public void BoardRender(Board board)
        {
            //variaveis
            int column = board.Height;
            int row = board.Width;
            Agents[,] grid = board.grid;



            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= column; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    if (grid[i, j] != null)
                    {
                        if (grid[i, j].MyType == AgentType.human)
                        {
                            Console.Write(" H ");
                        }
                        else
                        {
                            Console.Write(" Z ");
                        }
                    }
                    else
                    {
                        Console.Write(" . ");
                    }
                    //Check for agent inside board.grid[,]
                    //if != null inside array
                        //(if) Check for Human
                            //print the H id
                        //Else
                            //print the Z id
                    //Else
                    
                        //Console.Write(" . ");
                }
            }
        }

    }
}
