using Microsoft.AspNetCore.Mvc;
using AppointmentSchedulerproject.Data;
using AppointmentSchedulerproject.Models;
using System.Linq;
using AppointmentSchedulerproject.Data;
using AppointmentSchedulerproject.Models;

namespace AppointmentSchedulerproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
                return BadRequest("User already exists.");

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("User registered.");
        }

        [HttpPost("losgin")]
        public IActionResult Login(User login)
        {
            var user = _context.Users.FirstOrDefault(u =>
                u.Email == login.Email && u.Password == login.Password);

            if (user == null)
                return Unauthorized("Invalid credentials.");

            return Ok("Login successful.");
        }
    }
}
