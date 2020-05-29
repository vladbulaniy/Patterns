using Newtonsoft.Json;
using Patterns.AbstractFactory;
using Patterns.Builder;
using Patterns.FactoryMethod;
using Patterns.Prototype;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------Factory Method ------*/
            var p1 = ProductFactory.Create<ConcreteProduct>();
            var pasta = ProductFactory.Create<Pasta>();

            pasta.Prepare();

            /*------Abstract Factory ------*/
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();


            /*------Builder ------*/
            Console.WriteLine("-------------------------List Of Toys-----------------------------------");
            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            var toyA = toyACreator.GetToy();
            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            var toyB = toyBCreator.GetToy();
            
            Console.WriteLine(JsonConvert.SerializeObject(toyB));
            Console.WriteLine(JsonConvert.SerializeObject(toyA));

            Console.ReadKey();


            /*-------------------------------------Prototype -----------------------------------------*/
            Console.WriteLine("------------------------- Prototype example -----------------------------------");
            ConcretePrototype1 cp1 = new ConcretePrototype1("This is Concrete 1");
            ConcretePrototype1 cc1 = (ConcretePrototype1)cp1.Clone();
            Console.WriteLine("Cloned: {0}", cc1.Id);
            ConcretePrototype2 cp2 = new ConcretePrototype2("This is Concrete 2");
            ConcretePrototype2 cc2 = (ConcretePrototype2)cp2.Clone();
            Console.WriteLine("Cloned: {0}", cc2.Id);
            Console.ReadLine();
        }
    }
}
