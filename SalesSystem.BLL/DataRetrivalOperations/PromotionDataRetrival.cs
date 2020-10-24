using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DataRetrivalOperations
{
    public class PromotionDataRetrival : IDataRetrival
    {
        private readonly SalessystemContext context;

        public PromotionDataRetrival()
        {
            context = new SalesDbContextFactory().CreateDbContext();
        }

        public List<string> GetDealers()
        {
            return context.User.Where(p => p.Role.RoleName == "Dealer").Select(p => p.UserName).ToList();
        }

        public List<string> GetPromotiontypes()
        {
            return context.Promotion.Select(p => p.Name).ToList();
        }

        public List<string> GetProductModels()
        {
            return context.Product.Select(p => p.ModelName).ToList();
        }


    }
}
