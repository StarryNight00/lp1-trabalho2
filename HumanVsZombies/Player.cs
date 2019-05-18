using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Player : Agents
    {
        // Empty Contructor
        public Player(AgentType type) : base(type) { }

        public override string ToString()
        {
            // Create temporary string 
            // Check if its Human or Zombie
            return base.ToString();

          
        }
    }
}
