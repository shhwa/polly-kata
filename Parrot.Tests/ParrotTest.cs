using NUnit.Framework;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Test]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            IParrot parrot = new NorwegianBlueParrot( 0, true);
            Assert.That(0.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            IParrot parrot = new NorwegianBlueParrot( 1.5, false);
            Assert.That(18.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            IParrot parrot = new NorwegianBlueParrot(4, false);
            Assert.That(24.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            IParrot parrot = new AfricanParrot(0);
            Assert.That(12.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            IParrot parrot = new AfricanParrot(1);
            Assert.That(3.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            IParrot parrot = new AfricanParrot(2);
            Assert.That(0.0, Is.EqualTo(parrot.GetSpeed()));
        }

        [Test]
        public void GetSpeedOfEuropeanParrot()
        {
            IParrot parrot = new EuropeanParrot();
            Assert.That(12.0, Is.EqualTo(parrot.GetSpeed()));
        }
        
        [Test]
        public void GetCryOfEuropeanParrot()
        {
            IParrot parrot = new EuropeanParrot();
            Assert.That("Sqoork!", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryOfAfricanParrot()
        {
            IParrot parrot = new AfricanParrot(0);
            Assert.That("Sqaark!", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            IParrot parrot = new NorwegianBlueParrot(4, false);
            Assert.That("Bzzzzzz", Is.EqualTo(parrot.GetCry()));
        }
        
        [Test]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            IParrot parrot = new NorwegianBlueParrot(0, false);
            Assert.That("...", Is.EqualTo(parrot.GetCry()));
        }
    }
}