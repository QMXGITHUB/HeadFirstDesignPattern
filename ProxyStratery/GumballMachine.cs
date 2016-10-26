namespace ProxyStratery
{
    public class GumballMachine
    {
        private readonly string location;

        public GumballMachine(string location)
        {
            this.location = location;
        }

        public string GetLocation()
        {
            return location;
        }

        public string GetStatus()
        {
            return "waiting for quarter";
        }
    }
}