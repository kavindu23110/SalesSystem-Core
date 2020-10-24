using SalesSystem.BLL.DTO;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.UserOperations
{
    public class LoginProcess : OperationsBase
    {

        public (bool, DTO_User) ValidateLogin(DTO.DTO_User dTO)
        {

            (var lstuser, var user) = FindUserNameOnDatabase(dTO);

            return CreateLoginResult(lstuser, user); ;
        }

        private (bool, DTO_User) CreateLoginResult(List<User> lstuser, User user)
        {
            if (user != null)
            {
                return (true, CreateUserObjectAccordingly(user));
            }
            else
            {
                return (false, null);
            }
        }

        private DTO_User CreateUserObjectAccordingly(User user)
        {
            DTO_User dTO = new DTO_User();
            dTO.username = user.UserName;
            dTO.UserType = context.Role.Where(p => p.Id == user.RoleId).FirstOrDefault().RoleName;
            dTO.IsActive = user.IsActive;
            return dTO;
        }

        private (List<User> userlist, User user) FindUserNameOnDatabase(DTO_User dTO)
        {
            var userlist = context.User.Where(p => p.UserName == dTO.username).ToList();
            var user = userlist.Where(p => p.Password == dTO.Password).FirstOrDefault();
            return (userlist, user);
        }
    }
}
