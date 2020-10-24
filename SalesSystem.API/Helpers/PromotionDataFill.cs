using SalesSystem.API.Models;
using SalesSystem.BLL.DataRetrivalOperations;

namespace SalesSystem.Helpers
{
    public class PromotionDataFill
    {

        private readonly PromotionDataRetrival dataRetrieve;


        public PromotionDataFill()
        {
            dataRetrieve = new PromotionDataRetrival();
        }

        internal DetailsModel FillDetailsTemplate()
        {
            DetailsModel detailsModel = new DetailsModel();
            detailsModel.Dealers = dataRetrieve.GetDealers();
            detailsModel.Promotions = dataRetrieve.GetPromotiontypes();
            return detailsModel;
        }
    }
}
