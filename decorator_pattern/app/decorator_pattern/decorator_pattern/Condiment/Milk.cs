
namespace decorator_pattern.Condiment
{
    public class Milk : ICondimentDecorator
    {
        private IBeverage beverage;

        public Milk(IBeverage beverage) {
            this.beverage = beverage;
        }

        public string getDescription() {
            return string.Format("{0}, {1}", beverage.getDescription(), "milk");
        }

        public decimal getCost() {
            return beverage.getCost() + .1m;
        }
    }
}