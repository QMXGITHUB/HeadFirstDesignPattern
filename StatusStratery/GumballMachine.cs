using System.Collections.Generic;

namespace StatusStratery
{
    class GumballMachine
    {
        static int NO_QUARTER = 1;
        static int HAS_QUARTER = 2;

        int state;

        public GumballMachine()
        {
            state = NO_QUARTER;
        }

        public string InsertQuarter()
        {
            var result = default(string);

            if (state == HAS_QUARTER)
            {
                result = "You can't insert another quarter";
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                result = "You inserted a quarter";
            }

            return result;
        }

        public string TurnCrank()
        {
            var result = default(string);

            if (state == NO_QUARTER)
            {
                result = "You turned but there's no quarter";
            }
            else if(state == HAS_QUARTER)
            {
                result = "You turned...A gumball comes rolling out the slot";
                state = NO_QUARTER;
            }

            return result;
        }
    }
}
