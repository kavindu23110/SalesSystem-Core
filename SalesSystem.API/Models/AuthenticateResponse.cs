using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.API.Models
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }
        public string Error  { get; set; }
    }
}
