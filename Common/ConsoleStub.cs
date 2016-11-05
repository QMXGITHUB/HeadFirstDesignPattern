using System.Collections.Generic;

namespace Common
{
    public interface IConsole
    {
        void WriteLine(string message);
    }

    public class ConsoleStub:IConsole
    {
        private List<string> allConsole;

        public ConsoleStub()
        {
            allConsole = new List<string>();
        }
        
        public List<string> GetAllConsole()
        {
            return allConsole;
        }

        public void WriteLine(string message)
        {
            allConsole.Add(message);
        }
    }
}