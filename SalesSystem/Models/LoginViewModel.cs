using System;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public class LoginviewModel
    {
        [Required]
        [EmailAddress]
        public String username { get; set; }
        [Required]
        public String password { get; set; }

    }
}