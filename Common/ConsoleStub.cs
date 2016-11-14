using System.Collections.Generic;

namespace Common
{
    public class ConsoleStub
    {
        private static List<string> allConsole = new List<string>();
        public static List<string> GetAllConsole()
        {
            return allConsole;
        }

        public static void WriteLine(string message)
        {
            allConsole.Add(message);
        }

        public static void Clear()
        {
            allConsole.Clear();
        }
    }
}