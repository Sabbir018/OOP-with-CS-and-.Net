using System;

public class Dell : Laptop
{
    public bool TouchScreen => false;

    public void TurnOn()
    {
        Console.WriteLine("Dell is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Dell is turning off!");
    }
}