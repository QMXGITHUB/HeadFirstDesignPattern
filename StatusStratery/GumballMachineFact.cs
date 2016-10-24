using System.Collections.Generic;
using Xunit;

namespace StatusStratery
{
    public class GumballMachineFact
    {
        [Fact]
        public void Should_roll_out_gumball_when_you_insert_a_quarter()
        {
            var gumballMachine = new GumballMachine(5);

            var results = gumballMachine.InsertQuarter();
            Assert.Equal("You inserted a quarter", results);
            var turnCrank = gumballMachine.TurnCrank();
            turnCrank.ShouldContain("You turned...");
            turnCrank.ShouldContain("A gumball comes rolling out the slot");
            int count = gumballMachine.GetCount();
            Assert.Equal(4, count);
        }
        
        [Fact]
        public void should_return_quarter_when_eject_quarter()
        {
            var gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            var ejectQuarter = gumballMachine.EjectQuarter();
            Assert.Equal("Quarter returned", ejectQuarter);
            List<string> crank = gumballMachine.TurnCrank();
            crank.ShouldContain("You turned but there's no quarter");
            Assert.Equal(5, gumballMachine.GetCount());
        }

        [Fact]
        public void should_return_you_have_not_insert_a_quarter_when_you_press_eject_quarter()
        {
            var gumballMachine = new GumballMachine(1);
            var ejectQuarter = gumballMachine.EjectQuarter();
            Assert.Equal("You haven't inserted a quarter", ejectQuarter);
        }

        [Fact]
        public void should_not_insert_quarter_twice_continuously()
        {
            var gumballMachine = new GumballMachine(2);
            var first = gumballMachine.InsertQuarter();
            Assert.Equal("You inserted a quarter", first);
            var second = gumballMachine.InsertQuarter();
            Assert.Equal("You can't insert another quarter", second);
        }

        [Fact]
        public void should_return_no_gumballs_when_there_is_no_gumballs()
        {
            var gumballMachine = new GumballMachine(1);
            var first = gumballMachine.InsertQuarter();
            var turnCrank = gumballMachine.TurnCrank();
            turnCrank.ShouldContain("You turned...");
            turnCrank.ShouldContain("A gumball comes rolling out the slot");
            turnCrank.ShouldContain("Oops, out of gumballs!");

            var second = gumballMachine.InsertQuarter();
            Assert.Equal("You can't insert a quarter, the machine is sold out", second);

            List<string> secondTurn = gumballMachine.TurnCrank();
            secondTurn.ShouldContain("You turned, but there are no gumballs");
        }


    }
}