using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    /// <summary>
    /// Class Agents
    /// </summary>
    public abstract class Agents
    {
        /* brief Propriedades de bla bla */
        public AgentType MyType { get; set; }

        /// <summary>
        /// Constructor Agents
        /// </summary>
        /// <param name="mytype"></param>
        public Agents(AgentType mytype)
        {
            MyType = mytype;
        }
        /// <summary>
        /// Method Toroidal
        /// </summary> 
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="board"></param>
        /// <returns>retVal</returns>
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
        // Metodo q faz infeção de humanos
        public void Infection(Agents agent, Board board)
        {
            agent.MyType = AgentType.zombie;
            agent.Id = board.z + board.Z;

            if (agent is Player)
            {
                board.Z++;
            }
            else
                board.z++;
        }
    }
}