using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory
{
    public class Nokia : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
