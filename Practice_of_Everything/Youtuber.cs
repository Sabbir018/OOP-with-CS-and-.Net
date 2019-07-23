using System;

public class Youtuber : Creator
{
    public override void Create()
    {
        if ( base.CreativityLevel >= 50 && base.EnergyLevel >= 55 )
        {
            this.BrainstormingVideoIdeas();
            this.CreateScript();
            this.EditingVideo();
            this.RenderingVideo();
        }
        else
        {
            throw new Exception("Doesn't have enough Creativity or Tired to make video.!!");
        }
    }

    private void BrainstormingVideoIdeas()
    {
        base.CreativityLevel = base.CreativityLevel - 5;
        base.EnergyLevel = base.EnergyLevel - 5;
        Console.WriteLine("Brainstorming video ideas.!!!");
    }

    private void CreateScript()
    {
        base.CreativityLevel = base.CreativityLevel - 5;
        base.EnergyLevel = base.EnergyLevel - 5;
        Console.WriteLine("Creating video scripts.!!!");
    }

    private void EditingVideo()
    {
        base.CreativityLevel = base.CreativityLevel - 1;
        base.EnergyLevel = base.EnergyLevel - 5;
        Console.WriteLine("Editing video.!!!");
    }

    private void RenderingVideo()
    {
        base.CreativityLevel = base.CreativityLevel - 5;
        base.EnergyLevel = base.EnergyLevel - 1;
        Console.WriteLine("Rendering video.!!!");
    }
}