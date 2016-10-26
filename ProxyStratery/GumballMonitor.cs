using System.Collections.Generic;

namespace ProxyStratery
{
    public class GumballMonitor
    {
        private readonly GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public List<string> Report()
        {
            var result = new List<string>();

            result.Add("Gumball Machine: " + machine.GetLocation());
            result.Add("Current State: " + machine.GetStatus());
            return result;
        }
    }
}