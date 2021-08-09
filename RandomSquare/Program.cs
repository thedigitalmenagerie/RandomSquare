using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var Random = new Random();
            var Numbers = new List<int>();

            while (Numbers.Count < 20)
            {
                int rnd = Random.Next(0, 50);
                Numbers.Add(rnd);
            }
            Console.WriteLine($"The 20 random numbers between 0 and 50 are {String.Join(", ", Numbers)}.");

            var SquaredNumbers = Numbers.Select(x => x * x);
            Console.WriteLine($"The list of 20 random numbers between 0 and 50 squared are: {String.Join(",", SquaredNumbers)}");

            var EvenSquaredNumbers = SquaredNumbers.Where(x => x % 2 == 0);
            Console.WriteLine($"Only the even  numbers in the list of 20 random numbers between 0 and 50 are squared: {String.Join(",", EvenSquaredNumbers)}");
        }
    }
}
