using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory
{
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();        
    }
}
