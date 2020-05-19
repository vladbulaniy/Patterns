using System;

namespace Patterns.FactoryMethod
{
    public class Pasta : Product
    {
        protected internal override void PostConstruction()
        {
            throw new NotImplementedException();
        }
        public int Width { get; set; }
        public string Color { get; set; }

        public void Prepare()
        {
            Console.Write("Wait please just about 10 minutes");
        }
    }
}
