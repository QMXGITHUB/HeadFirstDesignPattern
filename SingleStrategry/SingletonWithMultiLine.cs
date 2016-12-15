namespace SingleStrategry
{
    public class SingletonWithMultiLine
    {
        private volatile static SingletonWithMultiLine uniqueInstance = new SingletonWithMultiLine();
        private static readonly object lockHelper = new object();
        private SingletonWithMultiLine()
        {
            
        }
        public static SingletonWithMultiLine GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockHelper)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new SingletonWithMultiLine();
                }
            }
            return uniqueInstance;
        }
    }
}
