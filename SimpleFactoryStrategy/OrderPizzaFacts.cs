using StatusStratery;
using Xunit;

namespace SimpleFactoryStrategy
{
    public class OrderPizzaFacts
    {
        [Fact]
        public void order_cheese_pizza()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            pizzaStore.OrderPizza("cheese");

            var outPut = console.GetAllConsole();
            outPut.ShouldContain("Order Cheese Pizza");
            outPut.ShouldContain("Prepare Pizza");
            outPut.ShouldContain("Bake Pizza");
            outPut.ShouldContain("Cut Pizza");
            outPut.ShouldContain("Box Pizza");
        }

        [Fact]
        public void order_greek_pizza()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            pizzaStore.OrderPizza("greek");

            var outPut = console.GetAllConsole();
            outPut.ShouldContain("Order Greek Pizza");
        }

        [Fact]
        public void order_pepperoni_pizza()
        {
            var console = new ConsoleStub();
            var pizzaStore = new PizzaStore(console);
            pizzaStore.OrderPizza("pepperoni");

            var outPut = console.GetAllConsole();
            outPut.ShouldContain("Order Pepperoni Pizza");
        }
    }
}
