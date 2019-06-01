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
            int column = board.Width;
            int row = board.Height;
            Agents[,] grid = board.grid;

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    //Debug writeLines
                    //Console.WriteLine(i);
                    //Console.WriteLine(j);

                    if (grid[j, i] == null)
                    {
                        Console.Write(" . ");
                    }
                    else
                    {
                        if (grid[j, i].MyType == AgentType.human)
                        {
                            Console.Write(" H ");
                        }
                        else
                        {
                            Console.Write(" Z ");
                        }  
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
