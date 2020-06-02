namespace Structural.Bridge
{
    public class SendSMS: SendData
    {
        public override void Send()
        {
            _iBridgeComponent.Send("SMS");
        }
    }
}
