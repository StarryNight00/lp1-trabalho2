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
    }
}
