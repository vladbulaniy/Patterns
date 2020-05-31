using Structural.Adapter;
using Structural.Adapter.Interfaces;
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
        }
    }
}
