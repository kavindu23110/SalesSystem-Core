using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DataRetrivalOperations
{
    public class User_RoledataRetrival : IDataRetrival
    {
        private readonly SalessystemContext context;

        public User_RoledataRetrival(SalessystemContext contexts)
        {
            context = contexts;
        }
        public User_RoledataRetrival()
        {
            context = new SalesDbContextFactory().CreateDbContext();
        }

        public List<string> GetRoles()
        {
            return context.Role.Where(p => p.Isactive == true)
                  .Select(p => p.RoleName).ToList();
        }


    }
}
