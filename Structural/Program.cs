using Structural.Adapter;
using Structural.Adapter.Interfaces;
using Structural.Bridge;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using System;
using System.Collections.Generic;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------Adapter ---------------------------*/
            Console.WriteLine("-------------------------Adapter-----------------------------------");
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();

            /*---------------------------- Bridge ---------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------- Bridge -----------------------------------");
            SendData _sendData = new SendEmail();
            _sendData._iBridgeComponent = new WebService();
            _sendData.Send();

            _sendData._iBridgeComponent = new ThirdPartyAPI();
            _sendData.Send();

            _sendData = new SendSMS();
            _sendData._iBridgeComponent = new WebService();
            _sendData.Send();

            _sendData._iBridgeComponent = new ThirdPartyAPI();
            _sendData.Send();

            Console.ReadLine();

            /*---------------------------- Composite ---------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------- Composite -----------------------------------");
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            //composite gift
            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 289);
            var plainToy = new SingleGift("PlainToy", 587);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);
            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");
            Console.ReadLine();

            /*---------------------------- Decorator ---------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------- Decorator -----------------------------------");
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var preOrder = new Preorder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var premiumPreorder = new PremiumPreorder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());

            Console.ReadLine();


            /*---------------------------- Facade ---------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------- Facade -----------------------------------");
            var restaurant = new OnlineRestaurant();
            var shippingService = new ShippingService();

            var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
            var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };

            restaurant.AddOrderToCart(chickenOrder);
            restaurant.AddOrderToCart(sushiOrder);
            restaurant.CompleteOrders();

            shippingService.AcceptOrder(chickenOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();

            shippingService.AcceptOrder(sushiOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();

            Console.ReadLine();

        }

    }
}
