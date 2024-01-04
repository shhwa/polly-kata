using NUnit.Framework;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Test]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 0, true);
            Assert.That(0.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 1.5, false);
            Assert.That(18.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 4, false);
            Assert.That(24.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            var parrot = new Parrot(ParrotTypeEnum.AFRICAN, 0, 0, false);
            Assert.That(12.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            var parrot = new Parrot(ParrotTypeEnum.AFRICAN, 1, 0, false);
            Assert.That(3.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            var parrot = new Parrot(ParrotTypeEnum.AFRICAN, 2, 0, false);
            Assert.That(0.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfEuropeanParrot()
        {
            var parrot = new Parrot(ParrotTypeEnum.EUROPEAN, 0, 0, false);
            Assert.That(12.0, Is.EqualTo(parrot.GetSpeed()));
        }
        
        [Test]
        public void GetCryOfEuropeanParrot()
        {
            var parrot = new Parrot(ParrotTypeEnum.EUROPEAN, 0, 0, false);
            Assert.That("Sqoork!", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryOfAfricanParrot()
        {
            var parrot = new Parrot(ParrotTypeEnum.AFRICAN, 2, 0, false);
            Assert.That("Sqaark!", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 4, false);
            Assert.That("Bzzzzzz", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 0, false);
            Assert.That("...", Is.EqualTo(parrot.GetCry()));
        }
    }
}