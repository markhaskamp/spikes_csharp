using System;

namespace decorator_pattern.Component
{
    public class HouseBlend : IBeverage
    {
        public string getDescription() {
            return "HouseBlend";
        }

        public decimal getCost() {
            return 1.00m;
        }
    }
}