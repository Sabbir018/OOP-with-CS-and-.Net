using System;

public class Dell : Laptop
{
    public override void TurnOn()
    {
        base.PowerOnTest();
        this.RAMCheck();
        this.FinalDellTest();
        Console.WriteLine("Dell is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Dell is turning off!");
    }

    private void RAMCheck()
    {
        Console.WriteLine("Testing the RAM!!!");
    }

    private void FinalDellTest()
    {
        Console.WriteLine("Everything is alright for Dell to turn on!!!");
    }
}