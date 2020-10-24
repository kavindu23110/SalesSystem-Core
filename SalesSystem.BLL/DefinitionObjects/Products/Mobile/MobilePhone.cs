using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DefinitionObjects.Products.Mobile
{
    public class MobilePhone : Product
    {
        public MobilePhone()
        {
            lstParts = new List<IParts>();
            cost = lstParts.Sum(p => p.cost);
        }

    }
}
