using SalesSystem.API.Models;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.API.Services
{
  public  interface IUserService
    {
        AuthenticateResponse Authenticate(LoginviewModel model);

    }
}
