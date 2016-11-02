using SimpleFactoryStrategy;

namespace FactoryStrategy
{
    public class PizzaStore
    {
        private ConsoleStub console;

        public PizzaStore(ConsoleStub console)
        {
            // TODO: Complete member initialization
            this.console = console;
        }
        public Pizza OrderPizza(string style, string type)
        {
            Pizza pizza = null;
            if (style.Equals("NY"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new NYStyleCheesePizza(console);
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new NYStyleVeggiePizza(console);
                }
            }
            else if(style.Equals("Chicago"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoSyleCheesePizza(console);
                }
                else if(type.Equals("veggie"))
                {
                    pizza = new ChicagoStyleVeggiePizza(console);
                }
            }
            else
            {
                console.WriteLine("Error: invalid type of pizza");
                return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}