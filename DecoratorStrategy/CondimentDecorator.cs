namespace DecoratorStrategy
{
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

    public class Whip : CondimentDecorator
    {
        private readonly Beverage berBeverage;

        public Whip(Beverage berBeverage)
        {
            this.berBeverage = berBeverage;
            description = berBeverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 19 + berBeverage.Cost();
        }
    }
}