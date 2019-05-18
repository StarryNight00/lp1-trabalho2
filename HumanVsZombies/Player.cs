using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Player
    {
        //
        public Agents[] Agents { get; set; }
        // 
        public AgentType MyType { get; private set; }

        // 
        public Player(AgentType type, int nagents)
        {
            MyType = type;
            Agents = new Agents[nagents];
        }
    }
}
