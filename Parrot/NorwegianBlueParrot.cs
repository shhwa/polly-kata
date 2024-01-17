using System;

namespace Parrot;

public class NorwegianBlueParrot : IParrot
{
    private double _voltage;
    private bool _isNailed; 

    public NorwegianBlueParrot(double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
    }
    public string GetCry()
    {
        return _voltage > 0 ? "Bzzzzzz" : "...";
    }

    public double GetSpeed()
    {
        return _isNailed ? 0 : GetBaseSpeed(_voltage);
    }
        
    private double GetBaseSpeed(double voltage)
    {
        return Math.Min(24.0, voltage * GetBaseSpeed());
    }
        
    private double GetBaseSpeed()
    {
        return 12.0;
    }
}