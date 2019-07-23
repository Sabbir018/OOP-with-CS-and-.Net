using System;

public abstract class Laptop
{
    public abstract void TurnOn();

    protected void PowerOnTest()
    {
        Console.WriteLine("Checking BIOS...");
        Console.WriteLine("Checking Network...");
        Console.WriteLine("Checking Memory...");
        Console.WriteLine("Checking Processor...");
        Console.WriteLine("Checking Peripherals...");
    }
}