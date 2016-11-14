namespace CommandStrategy
{
    public interface Command
    {
        void Execute();
    }

    public class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }

    public class Light
    {
        public void On()
        {
            
        }
    }
}
