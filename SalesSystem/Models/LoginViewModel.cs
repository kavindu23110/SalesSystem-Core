using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesSystem.Models
{
    public class LoginviewModel
    {    [Required]
         [EmailAddress]
        public String username { get; set; }
        [Required]
        public String password { get; set; }

    }
}