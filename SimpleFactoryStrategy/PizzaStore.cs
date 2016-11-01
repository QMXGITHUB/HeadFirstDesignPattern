namespace SimpleFactoryStrategy
{
    public class PizzaStore
    {
        private readonly IConsole console;

        public PizzaStore(IConsole console)
        {
            this.console = console;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = new Pizza(console);

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(console);
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza(console);
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(console);
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}