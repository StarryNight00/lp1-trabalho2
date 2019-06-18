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

        public int Id { get; private set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public Board board;

        /// <summary>
        /// Constructor Agents
        /// </summary>
        /// <param name="mytype"></param>
        public Agents(AgentType mytype, int id, int posX, int posY)
        {
            MyType = mytype;
            Id = id;
            PosX = posX;
            PosY = posY;
        }

        /// <summary>
        /// Method Toroidal
        /// </summary> 
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="board"></param>
        /// <returns>retVal</returns>
        public bool Toroidal(ref int newX, ref int newY, Board board, bool retVal)
        {
            if (newX >= board.Width)
            {
                newX = 0;
                retVal = !retVal;
            }
            else if (newX < 0)
            {
                newX = board.Width - 1;
                retVal = !retVal;
            }
            if (newY >= board.Height)
            {
                newY = 0;
                retVal = !retVal;
            }
            else if (newY < 0)
            {
                newY = board.Height - 1;
                retVal = !retVal;
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