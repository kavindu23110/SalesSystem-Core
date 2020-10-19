using Microsoft.Extensions.DependencyInjection;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SalesSystem.BLL.UserOperations
{
    public class RegistrationProcess : OperationsBase
    {


        public bool Register(DTO.DTO_User dTO)
        {
            try
            {
                var user = CreateNewUser(dTO);
                UserDetail userDetail = new UserDetail();
                using (var t = context.Database.BeginTransaction())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    t.Commit();
                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private User CreateNewUser(DTO.DTO_User dTO)
        {
            var roleId = context.Roles.Where(p => p.Isactive == true && p.RoleName == dTO.UserType).FirstOrDefault().Id;
            User user = new User();
            user.IsActive = true;
            user.Password = dTO.Password;
            user.RoleId = roleId;
            user.UserName = dTO.username;
            return user;

        }
    }
}
