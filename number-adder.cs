using System;

namespace NumAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Please enter a number to add to the sum, or enter 'calc' to get result.");
                var input = Console.ReadLine();

                if (input.ToLower() == "calc")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of all numbers is {0}", sum);
        }
    }
}
