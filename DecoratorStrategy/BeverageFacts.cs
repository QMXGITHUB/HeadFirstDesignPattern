using Xunit;

namespace DecoratorStrategy
{
    public class BeverageFacts
    {
        [Fact]
        public void mocha_HouseBlend()
        {
            Beverage houseBlend = new HouseBlend();
            CondimentDecorator houseBlendWithMocha = new Mocha(houseBlend);
            CondimentDecorator houseBlendWithWhip = new Whip(houseBlendWithMocha);
            Assert.Equal("House Blend Coffee, Mocha, Whip", houseBlendWithWhip.GetDescription());
        }
    }
}