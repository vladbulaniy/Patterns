using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Creational.FactoryMethod
{
    public static class ProductFactory
    {
        public static T Create<T>() where T: new()
        {
            try
            {
                var t = new T();
                return t;
            }
            catch (TargetInvocationException e)
            {
                var edi = ExceptionDispatchInfo.Capture(e.InnerException);
                edi.Throw();
                return default(T);                
            }
        }
    }
}
