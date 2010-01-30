using System;

namespace decorator_pattern.Condiment
{
    public class Whip : ICondimentDecorator
    {
        private IBeverage beverage;

        public Whip(IBeverage beverage) {
            this.beverage = beverage;
        }

        public string getDescription() {
            return string.Format("{0}, {1}", beverage.getDescription(), "whip");
        }

        public decimal getCost() {
            return beverage.getCost() + .8m;
        }
    }
}