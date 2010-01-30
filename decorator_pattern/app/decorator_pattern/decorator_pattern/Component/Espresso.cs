using System;

namespace decorator_pattern.Component
{
    public class Espresso : IBeverage
    {
        public string getDescription() {
            return "Espresso";
        }

        public decimal getCost() {
            return 3.00m;
        }
    }
}