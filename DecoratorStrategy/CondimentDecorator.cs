namespace DecoratorStrategy
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract string GetDescription();
    }

    public class Mocha : CondimentDecorator
    {
        private readonly Beverage berBeverage;

        public Mocha(Beverage berBeverage)
        {
            this.berBeverage = berBeverage;
        }

        public override double Cost()
        {
            return 20 + berBeverage.Cost();
        }

        public override string GetDescription()
        {
            return berBeverage.GetDescription() + ", Mocha";
        }
    }
}