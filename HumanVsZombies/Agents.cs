using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    /// <summary>
    /// Class Agents that controls the given AgentType to each Agent.
    /// Also controls Type exchange (human to zombie)
    /// </summary>
    public abstract class Agents
    {
        /*Set of Properties that allow to change the game state at all times*/
        /*Id is a private set Property because it is not a changeable property*/
        public AgentType MyType { get; set; }

        public int Id { get; private set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public Board board;

        /// <summary>
        /// Agents constructor. Gives a type, id and coordinate position to each Agent.
        /// </summary>
        /// <param name="mytype">Enumeration that gives out the Agents' type.</param>
        public Agents(AgentType mytype, int id, int posX, int posY)
        {
            MyType = mytype;
            Id = id;
            PosX = posX;
            PosY = posY;
        }

        /// <summary>
        /// Controls the Toroidal quality of the map.
        /// Resets the out of bounds coordinate for the correspondent
        /// in board coordinate.
        /// </summary> 
        /// <param name="newX">New coordinate in X.</param>
        /// <param name="newY">New coordinate in Y.</param>
        /// <param name="board">Current board of Agents.</param>
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

        /// <summary>
        /// Method that changes the AgentsType from Human to Zombie upon infection.
        /// </summary>
        /// <param name="agent">Turn given agent.</param>
        /// <param name="board">Current game Board.</param>
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