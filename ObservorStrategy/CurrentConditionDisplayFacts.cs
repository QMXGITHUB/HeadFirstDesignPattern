using Common;
using Xunit;

namespace ObservorStrategy
{
    public class CurrentConditionDisplayFacts
    {
        [Fact]
        public void test()
        {
            ConsoleStub.Clear();
            var weatherData = new WeatherData();
            var currentConditionDisplay = new CurrentConditionDisplay();
            weatherData.RejisterObserver(currentConditionDisplay);

            weatherData.SetMeasurement(12,65, 40);
            ConsoleStub.GetAllConsole().
                ShouldContain("Current conditions: " + 
                    12 + "F degrees and " + 
                    65 + "% humidity");
        }
    }
}