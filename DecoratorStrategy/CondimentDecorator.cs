namespace DecoratorStrategy
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 19 + beverage.Cost();
        }
    }

    public abstract class CondimentDecorator: Beverage
    {
    }

    public class Mocha : CondimentDecorator
    {
        private readonly Beverage berBeverage;

        public Mocha(Beverage berBeverage)
        {
            this.berBeverage = berBeverage;
            description = berBeverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 20 + berBeverage.Cost();
        }
    }
}