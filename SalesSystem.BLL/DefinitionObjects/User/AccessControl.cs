using SalesSystem.BLL.DTO;
using SalesSystem.BLL.UserOperations;
using System;

namespace SalesSystem.BLL.DefinitionObjects
{
    public class AccessControl
    {

        public (bool, DTO_User) Login(DTO_User dTO)
        {
            return new LoginProcess().ValidateLogin(dTO);
        }
        public void resetPassword()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
