using System;

public class Hp : Laptop
{
    public override void TurnOn()
    {
        base.PowerOnTest();
        this.ROMCheck();
        this.FinalHpTest();
        Console.WriteLine("Hp is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Hp is turning off!");
    }

    private void ROMCheck()
    {
        Console.WriteLine("ROM Testing!!!");
    }

    private void FinalHpTest()
    {
        Console.WriteLine("Everything is alright for Hp to turn on!!!");
    }
}