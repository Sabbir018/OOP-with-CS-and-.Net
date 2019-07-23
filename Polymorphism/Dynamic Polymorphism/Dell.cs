using System;

public class Dell : Laptop
{
    public bool TouchScreen => false;

    public void TurnOn()
    {
        Console.WriteLine("Dell is turning on!");
    }

    public void TurnOn(bool BIOSAccess)
    {
        if(BIOSAccess)
        {
            Console.WriteLine("Dell accessing BIOS!");
        }
        else
        {
            Console.WriteLine("Not accessing BIOS, dell turning on simply.");
        }
    }

    public void TurnOff()
    {
        Console.WriteLine("Dell is turning off!");
    }
}