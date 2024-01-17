using System;

namespace Parrot;

public class AfricanParrot
{
    private readonly int _numberOfCoconuts;
    public AfricanParrot(int numberOfCoconuts)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }
    public double GetSpeed()
    {
        return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
    }
    private double GetBaseSpeed()
    {
        return 12.0;
    }
    private double GetLoadFactor()
    {
        return 9.0;
    }

    public string GetCry()
    {
        return "Sqaark!";
    }
}