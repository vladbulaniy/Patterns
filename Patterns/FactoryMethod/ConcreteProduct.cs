using System;

namespace Patterns.FactoryMethod
{
    public class ConcreteProduct: Product
    {
        public ConcreteProduct() { }

        protected internal override void PostConstruction()
        {
            Console.WriteLine("ConcreteProduct: post construction");
        }
    }
}
