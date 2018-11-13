using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApplicationJWT.Models;

namespace WebApplicationJWT.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]LoginModel user)
        {
            Console.WriteLine("AuthController/login");
            if(user == null)
            {
                Console.WriteLine("AuthController/login->return BadRequest");
                return BadRequest("Invalid client request");
            }

            if (user.UserName == "Name" && user.Password == "Password")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretkey@375267215378"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:60000",
                    audience: "http://localhost:60000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                    );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                Console.WriteLine("AuthController/login->return Ok");
                return Ok(new { Token = tokenString });
            }
            else
            {
                Console.WriteLine("AuthController/login->return Unauthorized");
                return Unauthorized();
            }
        }
    }
}