namespace AbastractFactoryStrategy
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }

    public class Cheese
    {
    }

    public class Sauce
    {
    }

    public class Dough
    {
    }
}