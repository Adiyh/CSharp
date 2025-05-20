using Microsoft.AspNetCore.Mvc;
using MyAuthApp.DTOs;
using MyAuthApp.Services.Interfaces;

namespace MyAuthApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authService) : ControllerBase
{
    private readonly IAuthService _authService = authService;

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        var success = await _authService.RegisterAsync(model);
        if (!success) return BadRequest("User already exists.");
        return Ok("Registered successfully.");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel model)
    {
        var user = await _authService.LoginAsync(model);
        if (user == null) return Unauthorized("Invalid credentials.");
        return Ok("Login successful.");
    }
}
