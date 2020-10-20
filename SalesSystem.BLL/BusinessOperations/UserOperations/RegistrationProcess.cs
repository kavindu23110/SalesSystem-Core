using SalesSystem.DAL;
using System;
using System.Linq;

namespace SalesSystem.BLL.UserOperations
{//User Registration Service
    public class RegistrationProcess : OperationsBase
    {


        public bool Register(DTO.DTO_User dTO)
        {
            try
            {   //Map User DTO with Dataaccess model
                var user = CreateNewUser(dTO);
                //Save User with Transaction
                using (var t = context.Database.BeginTransaction())
                {
                    context.User.Add(user);
                    context.SaveChanges();
                    t.Commit();
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        //Create DTO To save In Database
        private User CreateNewUser(DTO.DTO_User dto)
        {
            var roleId = context.Role.Where(p => p.Isactive == true && p.RoleName == dto.UserType).FirstOrDefault().Id;
            User user = new User();
            user.IsActive = true;
            user.Password = dto.Password;
            user.RoleId = roleId;
            user.UserName = dto.username;
            return user;

        }
    }
}
