namespace Parrot;

public interface IParrot
{
    double GetSpeed();
    string GetCry();
}

public class EuropeanParrot : IParrot
{
    public double GetSpeed()
    {
        return 12.0;
    }

    public string GetCry()
    {
        return "Sqoork!";
    }
}