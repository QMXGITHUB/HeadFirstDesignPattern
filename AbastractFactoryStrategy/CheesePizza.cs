using SimpleFactoryStrategy;

namespace AbastractFactoryStrategy
{
    public class CheesePizza: Pizza
    {
        private readonly PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory, IConsole console):base(console)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            console.WriteLine("Preparing " + name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}