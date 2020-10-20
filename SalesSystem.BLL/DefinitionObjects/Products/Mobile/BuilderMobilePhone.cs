using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Products.Mobile
{
    class BuilderMobilePhone
    {
        internal Iproduct CreateMobilePhone(DTO_Product dTO_Product)
        {
            MobilePhone mobile = new MobilePhone();
            return mobile;

        }
    }
}
