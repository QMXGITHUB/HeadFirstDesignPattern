using SimpleFactoryStrategy;
using StatusStratery;
using Xunit;

namespace FactoryStrategy
{
    public class PizzaStoreFacts
    {
        [Fact]
        public void order_ny_cheese()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            
            pizzaStore.OrderPizza("NY", "cheese");

            console.GetAllConsole().ShouldContain("Order NY - Cheese Pizza");
        }

        [Fact]
        public void order_ny_veggie()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            
            pizzaStore.OrderPizza("NY", "veggie");

            console.GetAllConsole().ShouldContain("Order NY - Veggie Pizza");
        }

        [Fact]
        public void order_chicago_cheese()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            
            pizzaStore.OrderPizza("Chicago", "cheese");

            console.GetAllConsole().ShouldContain("Order Chicago - Cheese Pizza");
        }

        [Fact]
        public void order_chicago_veggie()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);

            pizzaStore.OrderPizza("Chicago", "veggie");

            console.GetAllConsole().ShouldContain("Order Chicago - Veggie Pizza");
        }

        [Fact]
        public void print_error_when_input_is_wrong()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);

            pizzaStore.OrderPizza("Chicago12", "veggie123");

            console.GetAllConsole().ShouldContain("Error: invalid type of pizza");
        }
    }
}
