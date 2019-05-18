using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Agents
    {
        private Player player;

        public AgentType MyType { get; private set; }

        public Agents(AgentType mytype)
        {
            MyType = mytype;
        }
    }
}
