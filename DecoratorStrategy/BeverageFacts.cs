using Xunit;

namespace DecoratorStrategy
{
    public class BeverageFacts
    {
        [Fact]
        public void mocha_HouseBlend()
        {
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Assert.Equal("House Blend Coffee, Mocha, Whip", houseBlend.GetDescription());
        }
    }
}