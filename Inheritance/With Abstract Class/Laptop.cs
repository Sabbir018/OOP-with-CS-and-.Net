using System;

public abstract class Laptop
{
    public virtual void TurnOn()
    {

        Console.WriteLine("Let's turn on the Laptop!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off!");
    }

    public abstract bool TouchScreen{ get; }

}