using Structural.Bridge.Interfaces;
using System;

namespace Structural.Bridge
{
    public class WebService : IBridgeComponent
    {
        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Webservice.");
        }
    }
}
