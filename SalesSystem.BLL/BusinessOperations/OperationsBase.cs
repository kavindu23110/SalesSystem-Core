using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;

namespace SalesSystem.BLL.UserOperations
{
    public class OperationsBase : Ioperations
    {
        protected readonly SalessystemContext context;

        public OperationsBase()
        {

            context = new SalesDbContextFactory().CreateDbContext();
        }
    }

}
