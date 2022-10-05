using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace BlogApiDemo.DataAccess
{
    public class BuildToken
    {
        private readonly IConfiguration _config;

        public BuildToken(IConfiguration config)
        {
            _config = config;
        }

        public string CreateToken()
        {
            var bytes = Encoding.UTF8.GetBytes(_config.GetValue<string>(
                "Jwt:Key"));

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _config.GetValue<string>(
                "Jwt:Issuer"),
                audience: _config.GetValue<string>(
                "Jwt:Audience"),
                expires:DateTime.Now.AddMinutes(15),
                signingCredentials:credentials
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);
        }
    }
}
