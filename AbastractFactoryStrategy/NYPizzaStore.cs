using SimpleFactoryStrategy;

namespace AbastractFactoryStrategy
{
    public class NYPizzaStore: PizzaStore
    {
        private ConsoleStub console;

        public NYPizzaStore(ConsoleStub console):base(console)
        {
            this.console = console;
        }

        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            var ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory, console);
            }

            return pizza;
        }
    }

    public abstract class PizzaStore
    {
        protected readonly IConsole console;

        public PizzaStore(IConsole console)
        {
            this.console = console;
        }

        public abstract Pizza CreatePizza(string item);
    }
}