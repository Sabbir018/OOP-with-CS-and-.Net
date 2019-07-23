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
            Console.WriteLine(hp.TouchScreen);
            hp.TurnOff();

            dell.TurnOn();
            Console.WriteLine(dell.TouchScreen);
            dell.TurnOff();
        }
    }
}
