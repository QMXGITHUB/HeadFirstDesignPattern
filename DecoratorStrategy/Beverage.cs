namespace DecoratorStrategy
{
    public class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }

    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
