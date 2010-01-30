using System;

namespace decorator_pattern.Condiment
{
    public class Soy : ICondimentDecorator
    {
        private IBeverage beverage;

        public Soy(IBeverage beverage) {
            this.beverage = beverage;
        }

        public string getDescription() {
            return string.Format("{0}, {1}", beverage.getDescription(), "soy");
        }

        public decimal getCost() {
            return beverage.getCost() + .40m;
        }
    }
}