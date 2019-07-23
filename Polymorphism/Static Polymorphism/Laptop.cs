using System;

public interface Laptop
{
    void TurnOn();

    void TurnOn(bool BIOSAccess);

    void TurnOff();
    
    bool TouchScreen{ get; }

}