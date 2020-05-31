using Structural.Adapter;
using Structural.Adapter.Interfaces;
using Structural.Bridge;
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
        }

    }
}
