using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory
{
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();        
    }
}
