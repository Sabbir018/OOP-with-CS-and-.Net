using System;
using System.Collections.Generic;

namespace Practice_of_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creator programmer = new Programmer();
            Creator youtuber = new Youtuber();

            programmer.Create();
            Console.WriteLine();
            youtuber.Create(); */

            List<Creator> creators = new List<Creator>() { new Programmer(), new Youtuber() };

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
        }
    }
}
