using Common;
using Xunit;

namespace CommandStrategy
{
    public class SimpleRemoteControlFacts
    {
        [Fact]
        public void test_light_on()
        {
            ConsoleStub.Clear();
            var controller = new SimpleRemoteControl();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            controller.SetCommand(lightOnCommand);
            controller.ButtonWasPressed();

            var allConsole = ConsoleStub.GetAllConsole();
            allConsole.ShouldContain("light is on");
        } 

        [Fact]
        public void light_on_and_undo()
        {
            ConsoleStub.Clear();
            var controller = new SimpleRemoteControl();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            controller.SetCommand(lightOnCommand);
            controller.ButtonWasPressed();
            controller.Undo();

            var allConsole = ConsoleStub.GetAllConsole();

            allConsole.ShouldContain("new a light and the light is off");
            allConsole.ShouldContain("light is on");
            allConsole.ShouldContain("Undo");
            allConsole.ShouldContain("light is off");
        } 
    }
}