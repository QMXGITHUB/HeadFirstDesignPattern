using Xunit;

namespace DecoratorStrategy
{
    public class BeverageFacts
    {
        [Fact]
        public void mocha_HouseBlend()
        {
            Beverage houseBlend = new HouseBlend();
            Mocha houseBlendWithMocha = new Mocha(houseBlend);
            Assert.Equal("House Blend Coffee, Mocha", houseBlendWithMocha.GetDescription());
        }
    }
}