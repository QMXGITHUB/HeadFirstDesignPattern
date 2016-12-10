using Common;

namespace ObservorStrategy
{
    public class CurrentConditionDisplay:Observer, DisplayElement
    {
        private float temperature;
        private float humidity;

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            ConsoleStub.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}