using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);

            int d4Roll = random.Next(1, 5);
            Console.WriteLine("d4 roll: " + d4Roll);

            int d6Roll = random.Next(1, 7);
            Console.WriteLine("d6 roll: " + d6Roll);

            int d8Roll = random.Next(1, 9);
            Console.WriteLine("d8 roll: " + d8Roll);

            int d10Roll = random.Next(1, 11);
            Console.WriteLine("d10 roll: " + d10Roll);

            int d12Roll = random.Next(1, 13);
            Console.WriteLine("d12 roll: " + d12Roll);

            int d20Roll = random.Next(1, 21);
            Console.WriteLine("d20 roll: " + d20Roll);

            int d100Roll = random.Next(1, 101);
            Console.WriteLine("d100 roll: " + d100Roll);
        }
    }
}
