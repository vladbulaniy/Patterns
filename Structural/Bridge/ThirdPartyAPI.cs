using Structural.Bridge.Interfaces;
using System;

namespace Structural.Bridge
{
    public class ThirdPartyAPI : IBridgeComponent
    {
        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Third PArty API.");
        }
    }
}
