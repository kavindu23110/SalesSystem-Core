using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem.BLL.UserOperations
{
    public class LoginProcess : OperationsBase
    {
        public LoginProcess(SalessystemContext contexts) : base(contexts)
        {
        }

        public bool ValidateLogin(DTO.DTO_User dTO)
        {
         
           (var lstuser,var user)= FindUserNameOnDatabase(dTO);
            CreateLoginResult(lstuser, user);
            return true;
        }

        private void CreateLoginResult(List<User> lstuser, User user)
        {
            if (user !=null)
            {
                CreateUserObjectAccordingly(user);
            }
        }

        private void CreateUserObjectAccordingly(User user)
        {
            throw new NotImplementedException();
        }

        private (List<User> userlist, User user) FindUserNameOnDatabase(DTO_User dTO)
        {
            var userlist =context.Users.Where(p => p.UserName == dTO.username ).ToList();
            var user = userlist.Where(p => p.Password == dTO.Password).FirstOrDefault();
            return (userlist, user);
        }
    }
}
