using System;

public class Programmer : Creator
{
    public override void Create()
    {
        if ( base.CreativityLevel >= 75 && base.EnergyLevel >= 80 )
        {
            this.BrainstormingSolutions();
            this.SelectingMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
        }
        else
        {
            throw new Exception("Doesn't have enough Creativity or Tired to program.!!");
        }
    }

    private void BrainstormingSolutions()
    {
        base.CreativityLevel = CreativityLevel - 15;
        base.EnergyLevel = base.EnergyLevel - 10;
        Console.WriteLine("Brainstorming solutions.!!!");
    }
    private void SelectingMostOptimalSolution()
    {
        base.CreativityLevel = CreativityLevel - 15;
        base.EnergyLevel = base.EnergyLevel - 10;
        Console.WriteLine("Optimal solution.!!!");
    }
    private void WriteCode()
    {
        base.CreativityLevel = CreativityLevel - 15;
        base.EnergyLevel = base.EnergyLevel - 10;
        Console.WriteLine("Writting code.!!!");
    }
    private void TestCode()
    {
        base.CreativityLevel = CreativityLevel - 15;
        base.EnergyLevel = base.EnergyLevel - 10;
        Console.WriteLine("Testing code.!!!");
    }
}