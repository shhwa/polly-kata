using System;

namespace Parrot
{
    public class Parrot
    {
        private readonly NorwegianBlueParrot _norwegianBlueParrot;
        private readonly AfricanParrot _africanParrot;
        private readonly EuropeanParrot _europeanParrot;
        private readonly ParrotTypeEnum _type;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _norwegianBlueParrot = new NorwegianBlueParrot(voltage, isNailed);
            _africanParrot = new AfricanParrot(numberOfCoconuts);
            _europeanParrot = new EuropeanParrot();
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return _europeanParrot.GetSpeed();
                case ParrotTypeEnum.AFRICAN:
                    return _africanParrot.GetSpeed();
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return _norwegianBlueParrot.GetSpeed();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        

        private double GetLoadFactor()
        {
            return 9.0;
        }

        private double GetBaseSpeed()
        {
            return 12.0;
        }

        public string GetCry()
        {
            string value;
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    value = "Sqoork!";
                    break;
                case ParrotTypeEnum.AFRICAN:
                    value = "Sqaark!";
                    break;
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    value = _norwegianBlueParrot.GetCry();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return value;
        }
    }

    public class EuropeanParrot
    {
        public EuropeanParrot()
        {
            
        }
        public double GetSpeed()
        {
            return 12.0;
        }
    }
}