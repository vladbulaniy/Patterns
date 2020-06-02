using Structural.Bridge.Interfaces;

namespace Structural.Bridge
{
    public abstract class SendData
    {
        public IBridgeComponent _iBridgeComponent;
        public abstract void Send();
    }
}
