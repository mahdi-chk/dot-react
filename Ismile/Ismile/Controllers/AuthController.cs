using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Ismile.Models;
using Ismile.Models.Dto;

namespace Ismile.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest(new { success = false, message = "Please fill in both fields." });
            }

            var secretaire = _context.Secretaires
                .FirstOrDefault(s => (s.NomUtilisateur == request.Username || s.Email == request.Username) && s.MotDePasse == request.Password);

            if (secretaire != null)
            {
                return Ok(new { success = true, role = "Secretaire", token = "fake-jwt-token" });
            }

            var dentiste = _context.Dentistes
                .FirstOrDefault(d => (d.NomUtilisateur == request.Username || d.Email == request.Username) && d.MotDePasse == request.Password);

            if (dentiste != null)
            {
                return Ok(new { success = true, role = "Dentiste", token = "fake-jwt-token" });
            }

            return Unauthorized(new { success = false, message = "Invalid login credentials." });
        }

    }


}
