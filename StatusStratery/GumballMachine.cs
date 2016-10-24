using System.Collections.Generic;

namespace StatusStratery
{
    class GumballMachine
    {
        int count;
        static int SOLD_OUT = 0;
        static int NO_QUARTER = 1;
        static int HAS_QUARTER = 2;
        static int SOLD = 3;

        int state = SOLD_OUT;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        public string InsertQuarter()
        {
            var result = default(string);

            if (state == HAS_QUARTER)
            {
                result = "You can't insert another quarter";
            }
            else if (state == SOLD_OUT)
            {
                result = "You can't insert a quarter, the machine is sold out";
            }
            else if (state == SOLD)
            {
                result = "Please wait, we're already giving you a gumball";
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                result = "You inserted a quarter";
            }

            return result;
        }

        public string EjectQuarter()
        {
            var result = default(string);
            if (state == HAS_QUARTER)
            {
                result = "Quarter returned";
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                result = "You haven't inserted a quarter";
            }
            else if (state == SOLD)
            {
                result = "Sorry, you already turned the crank";
            }
            else if (state == SOLD_OUT)
            {
                result = "You can't eject, you haven't insert a quarter yet";
            }

            return result;
        }

        public List<string> TurnCrank()
        {
            var result = new List<string>();

            if (state == SOLD)
            {
                result.Add("Turning twice doesn't get you another gumball");
            }
            else if (state == NO_QUARTER)
            {
                result.Add("You turned but there's no quarter");
            }
            else if (state == SOLD_OUT)
            {
                result.Add("You turned, but there are no gumballs");
            }
            else if(state == HAS_QUARTER)
            {
                result.Add("You turned...");
                state = SOLD;
                result.AddRange(Dispense());
            }
            return result;
        }

        private List<string> Dispense()
        {
            var result = new List<string>();
            if (state == SOLD)
            {
                result.Add("A gumball comes rolling out the slot");
                count = count - 1;
                if (count == 0)
                {
                    result.Add("Oops, out of gumballs!");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
            else if (state == NO_QUARTER)
            {
                result.Add("You need to pay first");
            }
            else if (state == SOLD_OUT)
            {
                result.Add("No gumball dispensed");
            }
            else if (state == HAS_QUARTER)
            {
                result.Add("No gumball dispensed");
            }

            return result;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
