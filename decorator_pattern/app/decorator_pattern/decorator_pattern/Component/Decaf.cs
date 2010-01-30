using System;

namespace decorator_pattern.Component
{
    public class Decaf : IBeverage
    {
        public string getDescription() {
            return "Decaf";
        }

        public decimal getCost() {
            return 4.00m;
        }
    }
}