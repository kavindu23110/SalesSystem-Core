using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            lstUserTypes = new List<string>();
            lstUserTypes.Add("Select item");
        }
   
        public String Firstname { get; set; }
   
        public String Lastname { get; set; }

     
        public String username { get; set; }
 
     
        public String Password { get; set; }

      
        public String Email { get; set; }
  
   
        public String ContactNo { get; set; }
    
        public string UserType { get; set; }

        public List<string> lstUserTypes { get; set; }

    }
}