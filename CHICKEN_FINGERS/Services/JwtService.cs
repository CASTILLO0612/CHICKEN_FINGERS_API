using CHICKEN_FINGERS.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CHICKEN_FINGERS.Services
{
    public class JwtService
    {
         private readonly IConfiguration _config;
         
         public JwtService(IConfiguration config)
         {
             _config = config;
         }
         
         public string GenerarToken(Usuario usuario)
         {
             var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
             var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
         
             var claims = new[]
             {
             new Claim(ClaimTypes.Name, usuario.NombreUsuario),
             new Claim(ClaimTypes.Role, usuario.Rol)
         };
         
             var token = new JwtSecurityToken(
                 issuer: _config["Jwt:Issuer"],
                 audience: _config["Jwt:Audience"],
                 claims: claims,
                 expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_config["Jwt:ExpiredMinutes"])),
                 signingCredentials: creds
            );
         
             return new JwtSecurityTokenHandler().WriteToken(token);
         }
    }
}
