using Common;

namespace CommandStrategy
{
    public interface Command
    {
        void Execute();
        void Undo();
    }

    public class LightOnCommand : Command
    {
        private Light light;
        private bool isLightOn;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            isLightOn = light.IsLightOn();
            light.On();
        }

        public void Undo()
        {
            ConsoleStub.WriteLine("Undo");
            if (!isLightOn)
            {
                light.Off();
            }
        }
    }

    public class Light
    {
        private bool isOn = false;

        public Light()
        {
            ConsoleStub.WriteLine("new a light and the light is off");
        }
        public void On()
        {
            isOn = true;
            ConsoleStub.WriteLine("light is on");
        }

        public bool IsLightOn()
        {
            return isOn;
        }

        public void Off()
        {
            isOn = false;
            ConsoleStub.WriteLine("light is off");
        }
    }
}
