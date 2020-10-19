using SalesSystem.BLL.DBContextFactory;
using System;
using System.Collections.Generic;

namespace SalesSystem.BLL.DefinitionObjects
{
    public class User : AccessControl
    {
        public User()
        {
           

        }

        private void GetUserDetails()
        {
            throw new NotImplementedException();
        }

        private void UpadateUserDetails(int userId, string email, string contactNo)
        {
            throw new NotImplementedException();
        }

        private void SetUserRole()
        {
            throw new NotImplementedException();
        }

        private string GetUserRole()
        {
            return UserRole;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }
        public List<ContactDetails> UserDetails { get; set; }
        private String UserRole { get; set; }
        public bool LoginStatus { get; set; }
        //Register User Provide By seperate service
        public bool Register(DTO.DTO_User dTO)
        {
            return new BLL.UserOperations.RegistrationProcess().Register(dTO);
        }


    }
}
