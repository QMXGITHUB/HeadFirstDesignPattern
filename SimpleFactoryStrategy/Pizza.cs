namespace SimpleFactoryStrategy
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IConsole console):base(console)
        {
            console.WriteLine("Order Pepperoni Pizza");
        }
    }

    public class GreekPizza : Pizza
    {
        public GreekPizza(IConsole console):base(console)
        {
            console.WriteLine("Order Greek Pizza");
        }
    }

    public class CheesePizza : Pizza
    {
        public CheesePizza(IConsole console):base(console)
        {
            console.WriteLine("Order Cheese Pizza");
        }
    }

    public class Pizza
    {
        protected IConsole console;

        public Pizza(IConsole console)
        {
            this.console = console;
        }

        public void Prepare()
        {
            console.WriteLine("Prepare Pizza");
        }

        public void Bake()
        {
            console.WriteLine("Bake Pizza");
        }

        public void Cut()
        {
            console.WriteLine("Cut Pizza");
        }

        public void Box()
        {
            console.WriteLine("Box Pizza");
        }
    }
}