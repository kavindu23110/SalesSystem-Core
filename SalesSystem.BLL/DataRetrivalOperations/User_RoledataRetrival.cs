using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem.BLL.DataRetrivalOperations
{
   public class User_RoledataRetrival:IDataRetrival
    {
        private readonly SalessystemContext context;

        public User_RoledataRetrival(SalessystemContext contexts)
        {
         context =  contexts;
        }

        public List<string> GetRoles()
        {
          return context.Roles.Where(p => p.Isactive == true)
                .Select(p => p.RoleName).ToList();
        }
    }
}
