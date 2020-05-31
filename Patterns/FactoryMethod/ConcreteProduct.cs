using System;

namespace Creational.FactoryMethod
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
