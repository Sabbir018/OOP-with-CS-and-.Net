using System;
using System.Collections.Generic;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop hp1 = new Hp();
            Laptop dell1 = new Dell();

            hp1.TurnOn();

            dell1.TurnOn();
        }
    }
}
