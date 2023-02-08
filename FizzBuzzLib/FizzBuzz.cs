namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz
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
    }
}
