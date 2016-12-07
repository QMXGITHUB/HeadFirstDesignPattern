using Common;
using Xunit;

namespace StrategyStrategy
{
    public class ModelDuckFact
    {
        [Fact]
        public void ModelDuckCannotFlyButQuack()
        {
            ConsoleStub.Clear();
            var modelDuck = new ModelDuck();
            modelDuck.Display();
            ConsoleStub.GetAllConsole().ShouldContain("I'm a model duck.");
            
            ConsoleStub.Clear();
            modelDuck.PerformFly();
            ConsoleStub.GetAllConsole().ShouldContain("I can't fly.");

            ConsoleStub.Clear();
            modelDuck.PerformQuack();
            ConsoleStub.GetAllConsole().ShouldContain("Quack");
        }
    }
}
