using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatusStratery;

namespace ProxyStratery
{
    [TestClass]
    public class GumballMachineFact
    {
        [TestMethod]
        public void get_gumball_info()
        {
            var machine = new GumballMachine("Seattle");
            var monitor = new GumballMonitor(machine);
            var report = monitor.Report();
            report.ShouldContain("Gumball Machine: Seattle");
            report.ShouldContain("Current State: waiting for quarter");
        }
    }
}
