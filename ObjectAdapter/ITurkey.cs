using Common;

namespace ObjectAdapter
{
    public class WildTurkey:ITurkey
    {
        public void Gobble()
        {
            ConsoleStub.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            ConsoleStub.WriteLine("I'm flying a short distance.");
        }
    }

    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }
}