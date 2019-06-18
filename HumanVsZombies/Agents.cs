using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    public abstract class Agents
    {
        public AgentType MyType { get; set; }

        public Agents(AgentType mytype)
        {
            MyType = mytype;
        }

        public bool Toroidal(ref int newX, ref int newY, Board board)
        {
            bool retVal = false;

            if (newX >= board.Width)
            {
                newX = 0;
                retVal = true;
            }
            else if (newX < 0)
            {
                newX = board.Width - 1;
                retVal = true;
            }
            if (newY >= board.Height)
            {
                newY = 0;
                retVal = true;
            }
            else if (newY < 0)
            {
                newY = board.Height - 1;
                retVal = true;
            }

            return retVal;
        }
    }
}