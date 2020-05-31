using Structural.Adapter.Interfaces;
using System.Collections.Generic;

namespace Structural.Adapter
{
    public class VendorAdapter: ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
