using Common;
using Xunit;

namespace TemplateStrategy
{
    public class MQClub
    {
        [Fact]
        public void make_coffee()
        {
            ConsoleStub.Clear();
            var coffee = new Coffee();
            coffee.PrepareRecipe();
            var allConsole = ConsoleStub.GetAllConsole();
            allConsole.ShouldContain("Boiling water");
            allConsole.ShouldContain("Dripping Coffee through filter");
            allConsole.ShouldContain("Pouring into cup");
            allConsole.ShouldContain("Adding Sugar and Milk");
        }

        [Fact]
        public void make_Tea()
        {
            ConsoleStub.Clear();
            var coffee = new Tea();
            coffee.PrepareRecipe();
            var allConsole = ConsoleStub.GetAllConsole();
            allConsole.ShouldContain("Boiling water");
            allConsole.ShouldContain("Steeping the tea");
            allConsole.ShouldContain("Pouring into cup");
            allConsole.ShouldContain("Adding Lemon");
        }
    }
}