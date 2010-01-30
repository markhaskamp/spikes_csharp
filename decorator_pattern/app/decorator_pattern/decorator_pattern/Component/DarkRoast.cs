using System;

namespace decorator_pattern.Component
{
    public class DarkRoast : IBeverage
    {
        public string getDescription() {
            return "DarkRoast";
        }

        public decimal getCost() {
            return 2.00m;
        }
    }
}