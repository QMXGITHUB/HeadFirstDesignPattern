namespace CommandStrategy
{
    public class SimpleRemoteControl
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ButtonWasPressed()
        {
            command.Execute();
        }

        public void Undo()
        {
            command.Undo();
        }
    }
}