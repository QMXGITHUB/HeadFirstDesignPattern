namespace AbastractFactoryStrategy
{
    public class NYPizzaIngredientFactory: PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
    }

    public class ReggianoCheese : Cheese
    {
    }

    public class MarinaraSauce : Sauce
    {
    }

    public class ThinCrustDough : Dough
    {
    }
}