using Newtonsoft.Json;
using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Creational.Singleton;
using System;

namespace Creational
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
            Console.WriteLine();
            Console.ReadKey();


            /*----------------------------Singleton ---------------------------*/
            Console.WriteLine("-------------------------Singleton-----------------------------------");
            Calculate.Instance.ValueOne = 10.5;
            Calculate.Instance.ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine("\n----------------------\n");
            Calculate.Instance.ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
