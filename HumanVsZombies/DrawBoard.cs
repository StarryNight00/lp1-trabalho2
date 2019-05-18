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


            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j >= column; j++)
                {
                    //Check for agent inside board.grid[,]
                    //if != null inside array
                        //(if) Check for Human
                            //print the H id
                        //Else
                            //print the Z id
                    //Else
                        Console.Write(" . ");
                }
            }
        }

    }
}
