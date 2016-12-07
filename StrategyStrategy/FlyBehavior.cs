using Common;

namespace StrategyStrategy
{
    public interface FlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings: FlyBehavior
    {
        public void Fly()
        {
            ConsoleStub.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay: FlyBehavior
    {
        public void Fly()
        {
            ConsoleStub.WriteLine("I can't fly.");
        }
    }
}