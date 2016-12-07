using Common;

namespace StrategyStrategy
{
    public interface QuackBehavior
    {
        void Quack();
    }

    public class QuackOnly: QuackBehavior
    {
        public void Quack()
        {
            ConsoleStub.WriteLine("Quack");
        }
    }
    public class MuteQuack: QuackBehavior
    {
        public void Quack()
        {
            ConsoleStub.WriteLine("<< Silence >>");
        }
    }
}