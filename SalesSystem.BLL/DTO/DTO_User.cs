using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DTO
{
  public  class DTO_User
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String ContactNo { get; set; }
        public string UserType { get; set; }
        public bool IsActive { get; set; }

    }
}
