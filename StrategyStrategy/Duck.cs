using Common;

namespace StrategyStrategy
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
           flyBehavior = new FlyNoWay();
            quackBehavior = new QuackOnly();
        }
        public override void Display()
        {
            ConsoleStub.WriteLine("I'm a model duck.");
        }
    }
}
