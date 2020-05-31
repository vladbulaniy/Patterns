namespace Structural.Bridge
{
    public class SendEmail: SendData
    {
        public override void Send()
        {
            _iBridgeComponent.Send("Email");
        }
    }
}
