using SalesSystem.SOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SalesSystem.SOAP
{
    [ServiceContract]
    interface IPromotionService
    {


        [OperationContract]
        bool SendPromotion(PromotionViewModel inputModel);
    }
}
