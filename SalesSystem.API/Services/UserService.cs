using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SalesSystem.API.Helpers;
using SalesSystem.API.Models;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.API.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications


        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings,IMapper mapper)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(LoginviewModel model)
        {

            var DTO = new DTO_User();
            _mapper.Map(model, DTO);

            (var result, var user) = new BLL.DefinitionObjects.User().Login(DTO);
            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse( token);
        }

  

        // helper methods

        private string generateJwtToken(DTO_User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("UserName", user.username.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
