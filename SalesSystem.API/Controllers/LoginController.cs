using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;

namespace SalesSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMapper _mapper;

        public LoginController(IMapper mapper)
        {
            _mapper = mapper;
        }

   

        public void login(LoginviewModel loginviewModel)
        {
            if (ModelState.IsValid)
            {
               var response= new API.Models.AuthenticateResponse();
                //valid User Login Requests Map to DTO
                var DTO = new DTO_User();
                _mapper.Map(loginviewModel, DTO);

                (var result, var user) = new SalesSystem.BLL.DefinitionObjects.User().Login(DTO);
                if (result)
                {

                }
                else
                {
                    response.Error = "Invalid username Or password";
                    return BadRequest(response);
                }
                 
              
            }
        }
    }
}
