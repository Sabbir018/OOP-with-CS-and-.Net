using System;

public class Hp : Laptop
{
    public bool TouchScreen => true;

    public void TurnOn()
    {
        Console.WriteLine("Hp is turning on!");
    }

    public void TurnOn(bool BIOSAccess)
    {
        if(BIOSAccess)
        {
            Console.WriteLine("Hp accessing BIOS!");
        }
        else
        {
            Console.WriteLine("Not accessing BIOS, hp turning on simply.");
        }
    }

    public void TurnOff()
    {
        Console.WriteLine("Hp is turning off!");
    }
}