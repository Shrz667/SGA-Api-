
using System;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
namespace SecuDeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthentificationController : ControllerBase
    {

        [HttpPost("login")]
        public IActionResult Login(string username, string password)

        {
            if (username != "shyraz" || password != "f2006")
                return Unauthorized("Identifiants invalides");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("dxyfjhcjyhdgyugfdtygjfvugfyjugdtkghfyutfjuiyrtfyutdudfhijgfyid");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]

            {
            new Claim (ClaimTypes.Name, username),
            new Claim(ClaimTypes.Role, "Admin")
            }),
                Expires = DateTime.Now.AddMinutes(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };



            var token = tokenHandler.CreateToken(tokenDescriptor);



            return Ok(new { token = tokenHandler.WriteToken(token) });
        }

    }
}