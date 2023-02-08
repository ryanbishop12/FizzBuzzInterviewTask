namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1, 20);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
