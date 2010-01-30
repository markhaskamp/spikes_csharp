
using decorator_pattern;
using decorator_pattern.Component;
using MbUnit.Framework;

namespace decorator_pattner_tests
{
    [TestFixture]
    public class Component_Test
    {
//        [SetUp]
//        public void SetUp() {
//            
//        }

        [Test]
        public void HouseBlend__createHouseBlendBeverage__descriptionIsHouseBlend() {
            IBeverage b = new HouseBlend();
            Assert.AreEqual("HouseBlend", b.getDescription());
        }

        [Test]
        public void HouseBlend__cost__is100() {
            IBeverage b = new HouseBlend();
            Assert.AreEqual(1.0m, b.getCost());
        }

        [Test]
        public void DarkRoast__createDarkRoastBeverage__descriptionIsDarkRoast() {
            IBeverage b = new DarkRoast();
            Assert.AreEqual("DarkRoast", b.getDescription());
        }

        [Test]
        public void DarkRoast__cost__is200() {
            IBeverage b = new DarkRoast();
            Assert.AreEqual(2.00m, b.getCost());
        }

        [Test]
        public void Espresso__createEspressoBeverage__descriptionIsEspresso() {
            IBeverage b = new Espresso();
            Assert.AreEqual("Espresso", b.getDescription());
        }

        [Test]
        public void Espresso__cost__is300() {
            IBeverage b = new Espresso();
            Assert.AreEqual(3.00m, b.getCost());
        }

        [Test]
        public void Decaf__createDecafBeverage__descriptionIsDecaf() {
            IBeverage b = new Decaf();
            Assert.AreEqual("Decaf", b.getDescription());
        }

        [Test]
        public void Decaf__cost__is400() {
            IBeverage b = new Decaf();
            Assert.AreEqual(4.00m, b.getCost());
        }
    }
}
