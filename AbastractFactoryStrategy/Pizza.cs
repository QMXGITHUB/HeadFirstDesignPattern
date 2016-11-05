using SimpleFactoryStrategy;

namespace AbastractFactoryStrategy
{
    public abstract class Pizza
    {
        protected readonly IConsole console;
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese Cheese;

        protected Pizza(IConsole console)
        {
            this.console = console;
        }

        public abstract void Prepare();

        public void Bake()
        {
        }

        public void Cut()
        {
        }

        public void Box()
        {
        }
    }
}