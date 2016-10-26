using System.Collections.Generic;
using Xunit;

namespace StatusStratery
{
    public class GumballMachineFact
    {
        [Fact]
        public void Should_roll_out_gumball_when_you_insert_a_quarter()
        {
            var gumballMachine = new GumballMachine();

            var results = gumballMachine.InsertQuarter();
            Assert.Equal("You inserted a quarter", results);

            var insertQuarterTwice = gumballMachine.InsertQuarter();
            Assert.Equal(insertQuarterTwice, "You can't insert another quarter");

            var turnCrank = gumballMachine.TurnCrank();
            Assert.Equal(turnCrank,"You turned...A gumball comes rolling out the slot");

            var crankTwice = gumballMachine.TurnCrank();
            Assert.Equal("You turned but there's no quarter", crankTwice);
        }
       
    }
}