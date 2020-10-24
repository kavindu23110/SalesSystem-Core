using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.DTO;
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
        public bool CheckUserNameAvilability(string UserName)
        {
            return !context.User.Where(p => p.IsActive == true && p.UserName == UserName).Any();

        }

        public DTO_User GetuserByUserName(string username)
        {
            var user = context.User.Where(p => p.UserName == username).FirstOrDefault();
            return CreateUserObjectAccordingly(user);
        }

        private DTO_User CreateUserObjectAccordingly(User user)
        {
            DTO_User dTO = new DTO_User();
            dTO.username = user.UserName;
            dTO.UserType = context.Role.Where(p => p.Id == user.RoleId).FirstOrDefault().RoleName;
            dTO.IsActive = user.IsActive;
            return dTO;
        }
    }
}
