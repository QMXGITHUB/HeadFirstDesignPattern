using Common;
using Xunit;

namespace ObjectAdapter
{
    public class TurkeyDuckAdapterFacts
    {
        [Fact]
        public void TurkeyToDuckAdapter()
        {
            ConsoleStub.Clear();
            var wildTurkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(wildTurkey);

            turkeyAdapter.Quack();
            ConsoleStub.GetAllConsole().ShouldContain("Gobble gobble");
        }
    }
}