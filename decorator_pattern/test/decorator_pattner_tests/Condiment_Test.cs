using decorator_pattern;
using decorator_pattern.Component;
using decorator_pattern.Condiment;
using MbUnit.Framework;

namespace decorator_pattner_tests
{
    [TestFixture]
    class Condiment_Test
    {

        [Test]
        public void Milk__costOfMilkAndHouseBlendIs110() {
            IBeverage b = new HouseBlend();
            b = new Milk(b);

            Assert.AreEqual(1.10m, b.getCost());
        }

        [Test]
        public void Milk__MildAndHouseBlendDescription() {
            IBeverage b = new HouseBlend();
            b = new Milk(b);
            Assert.AreEqual("HouseBlend, milk", b.getDescription());
        }

        [Test]
        public void Milk__costOfMilkAndDarkRoastIs210()
        {
            IBeverage b = new DarkRoast();
            b = new Milk(b);

            Assert.AreEqual(2.10m, b.getCost());
        }

        [Test]
        public void Milk__costOfMilkAndEspressoIs310()
        {
            IBeverage b = new Espresso();
            b = new Milk(b);

            Assert.AreEqual(3.10m, b.getCost());
        }

        [Test]
        public void Milk__costOfMilkAndDecafIs410()
        {
            IBeverage b = new Decaf();
            b = new Milk(b);

            Assert.AreEqual(4.10m, b.getCost());
        }

        [Test]
        public void Mocha__costOfMochaAndHouseBlendIs120() {
            IBeverage b = new HouseBlend();
            b = new Mocha(b);

            Assert.AreEqual(1.20m, b.getCost());
        }

        [Test]
        public void Mocha_costOfMilkMochaAndHouseBlendIs130() {
            IBeverage b = new HouseBlend();
            b = new Milk(b);
            b = new Mocha(b);
            Assert.AreEqual(1.30m, b.getCost());
        }

        [Test]
        public void Soy_CostOfSoyAndHouseBlendIs140() {
            IBeverage b = new HouseBlend();
            b = new Soy(b);
            Assert.AreEqual(1.4m, b.getCost());
        }

        [Test]
        public void Whip__CostOfWhipAndHouseBlendIs180() {
            IBeverage b = new HouseBlend();
            b = new Whip(b);
            Assert.AreEqual(1.8m, b.getCost());
        }

        [Test]
        public void various_combinations() {
            IBeverage b = new DarkRoast();
            b = new Mocha(b);
            b = new Whip(b);
            Assert.AreEqual("DarkRoast, mocha, whip", b.getDescription());
            Assert.AreEqual(3m, b.getCost());

            b = new Espresso();
            b = new Milk(b);
            b = new Mocha(b);
            b = new Whip(b);
            Assert.AreEqual("Espresso, milk, mocha, whip", b.getDescription());
            Assert.AreEqual(4.1m, b.getCost());
        }
    }
}
