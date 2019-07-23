using System;

public class Hp : Laptop
{
    public bool TouchScreen => true;

    public void TurnOn()
    {
        Console.WriteLine("Hp is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Hp is turning off!");
    }
}