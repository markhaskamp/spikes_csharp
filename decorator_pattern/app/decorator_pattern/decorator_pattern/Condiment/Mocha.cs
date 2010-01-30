using System;

namespace decorator_pattern.Condiment
{
    public class Mocha : ICondimentDecorator
    {
        private IBeverage beverage;

        public Mocha(IBeverage beverage) {
            this.beverage = beverage;
        }

        public string getDescription() {
            return string.Format("{0}, {1}", beverage.getDescription(), "mocha");
        }

        public decimal getCost() {
            return beverage.getCost() + .20m;
        }
    }
}