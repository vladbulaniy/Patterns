using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory
{
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
