using System;

public abstract class Creator
{
    private int _crativityLevel = 100;
    private int _energyLevel = 100;

    public int CreativityLevel
    {
        get
        {
            return _crativityLevel;
        }
        set
        {
            if ( value >= 0 && value <= 100 )
            {
                _crativityLevel = value;
            }
            else
            {
                throw new Exception("Creativity level can only be a value between 0 and 100.");
            }
        }
    }

    public int EnergyLevel
    {
        get
        {
            return _energyLevel;
        }
        set
        {
            if ( value >= 0 && value <= 100 )
            {
                _energyLevel = value;
            }
            else
            {
                throw new Exception("Energy level can only be a value between 0 and 100.");
            }
        }
    }

    public abstract void Create();
}