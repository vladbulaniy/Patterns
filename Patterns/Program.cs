using Newtonsoft.Json;
using Patterns.AbstractFactory;
using Patterns.Builder;
using Patterns.FactoryMethod;
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
        }
    }
}
