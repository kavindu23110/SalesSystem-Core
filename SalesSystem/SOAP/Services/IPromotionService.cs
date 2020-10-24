using SalesSystem.SOAP.Models;
using System.ServiceModel;

namespace SalesSystem.SOAP
{
    [ServiceContract]
    interface IPromotionService
    {


        [OperationContract]
        bool SendPromotion(PromotionViewModel inputModel);
    }
}
