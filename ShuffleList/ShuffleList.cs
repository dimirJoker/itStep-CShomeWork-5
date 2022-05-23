using System;
using System.Collections.Generic;

namespace ShuffleList
{
    internal class ShuffleList
    {
        static void Main(string[] args)
        {
            var random = new Random(); // generate random seed
            var list = new List<int>(); // create list

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(101));
            } // fill up list

            foreach (var item in list)
            {
                Console.Write("{0,5}", item);
            } // read unshuffled list

            Console.WriteLine();

            for (var i = 0; i < list.Count; i++)
            {
                var rInd = random.Next(list.Count);
                list.Insert(i, list[rInd]);
                list.
            } // shuffle list

            foreach (var item in list)
            {
                Console.Write("{0,5}", item);
            } // read shuffled list
            Console.ReadKey(true);
        }
    }
}