using Common;

namespace ObjectAdapter
{
    public class MallardDuck: IDuck
    {
        public void Quack()
        {
            ConsoleStub.WriteLine("Quack");
        }

        public void Fly()
        {
            ConsoleStub.WriteLine("I'm flying");
        }
    }

    public interface IDuck
    {
        void Quack();
        void Fly();
    }
}