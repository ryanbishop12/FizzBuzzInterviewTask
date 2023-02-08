using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }

        public string FizzBuzzifyAnInt(int input)
        {
            if(input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            } else if(input % 3 == 0)
            {
                return "Fizz";
            } else if(input % 5 == 0)
            {
                return "Buzz";
            } else
            {
                return input.ToString();
            }
        }

        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            List<string> FizzBuzzRange = new List<string>();
            for(int i = start; i <= end; i++)
            {
                FizzBuzzRange.Add(FizzBuzzifyAnInt(i));
            }
            return FizzBuzzRange;
        }
    }
}
