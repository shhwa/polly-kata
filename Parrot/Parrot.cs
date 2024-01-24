using System;

namespace Parrot
{
    public class Parrot
    {
        private readonly ParrotTypeEnum _type;
        private readonly IParrot _trueParrot;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    _trueParrot = new EuropeanParrot();
                    break;
                case ParrotTypeEnum.AFRICAN:
                    _trueParrot = new AfricanParrot(numberOfCoconuts);
                    break;
            }
        }

        public double GetSpeed()
        {
            return _trueParrot.GetSpeed();
        }

        public string GetCry()
        {
            return _trueParrot.GetCry();
        }
    }
}