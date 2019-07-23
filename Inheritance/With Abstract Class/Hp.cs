using System;

public class Hp : Laptop
{
    public override bool TouchScreen => true;

    public override void TurnOn()
    {
        Console.WriteLine("Hp is turning on!");
    }
}