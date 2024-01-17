using System;

namespace Parrot
{
    public class Parrot
    {
        private readonly NorwegianBlueParrot _norwegianBlueParrot;
        private readonly AfricanParrot _africanParrot;
        private readonly ParrotTypeEnum _type;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _norwegianBlueParrot = new NorwegianBlueParrot(voltage, isNailed);
            _africanParrot = new AfricanParrot(numberOfCoconuts);
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return GetBaseSpeed();
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
    }
}