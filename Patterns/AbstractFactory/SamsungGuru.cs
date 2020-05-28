using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
