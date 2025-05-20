using LaptopService.Core.Services.Interface;
using LaptopService.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaptopManagementSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var user = await _authService.AuthenticateAsync(model.Username, model.Password);
            if (user == null)
                return Unauthorized("Invalid username or password.");

            // You can return user info or a token here as needed
            return Ok(new { user.Id, user.Username });
        }

      
    }

    // DTOs for request models
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    // public class RegisterRequest { ... }
}
