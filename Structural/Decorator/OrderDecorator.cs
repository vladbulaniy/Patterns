using System;

namespace Structural.Decorator
{
    public class OrderDecorator : OrderBase
    {
        protected OrderBase _order;
        public OrderDecorator(OrderBase order) 
        {
            this._order = order;
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return _order.CalculateTotalOrderPrice();
        }
    }
}
