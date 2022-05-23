using System;

namespace ArrayShuffle
{
    internal class ArrayShuffle
    {
        static void Main(string[] args)
        {
            var random = new Random(); // generate random seed
            var array = new byte[10]; // create array
            random.NextBytes(array); // fill up array

            foreach (var item in array)
            {
                Console.Write("{0,5}", item);
            } // read unshuffled array

            Console.WriteLine();

            for (var i = 0; i < array.Length; i++)
            {
                var rIndex = random.Next(array.Length);
                (array[i], array[rIndex]) = (array[rIndex], array[i]);
            } // shuffle array

            foreach (var item in array)
            {
                Console.Write("{0,5}", item);
            } // read shuffled array
            Console.ReadKey(true);
        }
    }
}