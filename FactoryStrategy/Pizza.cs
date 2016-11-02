using SimpleFactoryStrategy;

namespace FactoryStrategy
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza(IConsole console)
        {
            console.WriteLine("Order Chicago - Veggie Pizza");
        }
    }

    public class ChicagoSyleCheesePizza : Pizza
    {
        public ChicagoSyleCheesePizza(IConsole console)
        {
            console.WriteLine("Order Chicago - Cheese Pizza");
        }
    }

    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza(IConsole console)
        {
            console.WriteLine("Order NY - Veggie Pizza");
        }
    }

    public class NYStyleCheesePizza : Pizza
    {

        public NYStyleCheesePizza(IConsole console)
        {
            console.WriteLine("Order NY - Cheese Pizza");
        }
    }

    public class Pizza
    {
        public void Prepare()
        {
        }

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