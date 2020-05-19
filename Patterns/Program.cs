using Patterns.FactoryMethod;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = ProductFactory.Create<ConcreteProduct>();
            var pasta = ProductFactory.Create<Pasta>();

            pasta.Prepare();
        }
    }
}
