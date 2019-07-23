using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop hp = new Hp();
            Laptop dell = new Dell();

            hp.TurnOn();
            hp.TurnOn(true);

            dell.TurnOn();
            dell.TurnOn(false);
        }
    }
}
