using System.Collections.Generic;
using Visualizer.GameLogic;

namespace Visualizer.AgentBrains
{
    public abstract class BaseBrain
    {
        // reference to the agent the brain is attached to
        protected Agent AttachedAgent;

        // commands queue that the Agent gets its actions from
        protected Queue<AgentAction> Commands = new Queue<AgentAction>();

        public virtual AgentAction GetNextAction()
        {
            return Commands.Count > 0 ? Commands.Dequeue() : null;
        }
        
        public virtual bool HasNextAction()
        {
            return Commands.Count > 0;
        }

        public virtual void Reset() // reset the brain
        {
            // IsReady = false;
            Commands.Clear();
        }
        
        // Child Brains must implement these methods
        public abstract void Start( Agent actor ); // start the brain, agent is passed so we can hook a coroutine to it, not the cleanest way 
        
        public void SetAttachedAgent(Agent agent)
        {
            AttachedAgent = agent;
        }
        
    }
}

