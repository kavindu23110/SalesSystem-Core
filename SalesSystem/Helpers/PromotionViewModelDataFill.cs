using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Helpers
{
    public class PromotionViewModelDataFill
    {

        private readonly PromotionDataRetrival dataRetrieve;


        public PromotionViewModelDataFill()
        {
            dataRetrieve = new PromotionDataRetrival();
        }

        internal void FillViewModel(ref PromotionViewModel promotionViewModel)
        {
            promotionViewModel.lstDealers = dataRetrieve.GetDealers();
            promotionViewModel.lstDealers = dataRetrieve.GetDealers();

            promotionViewModel.lstProducts = dataRetrieve.GetProductModels();
            promotionViewModel.lstProducts.Insert(0, "--Select Option--");

            promotionViewModel.lstPromotions = dataRetrieve.GetPromotiontypes();
            promotionViewModel.lstPromotions.Insert(0, "--Select Option--");
        }
    }
}
