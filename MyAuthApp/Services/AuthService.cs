using MyAuthApp.DTOs;
using MyAuthApp.Models;
using MyAuthApp.Repositories.Interfaces;
using MyAuthApp.Services.Interfaces;
using BCrypt.Net;

namespace MyAuthApp.Services;

public class AuthService(IUserRepository userRepository) : IAuthService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<bool> RegisterAsync(RegisterModel model)
    {
        if (await _userRepository.UserExistsAsync(model.Email))
            return false;

        var user = new User
        {
            Username = model.Username,
            Email = model.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password)
        };

        await _userRepository.AddUserAsync(user);
        return true;
    }

    public async Task<User?> LoginAsync(LoginModel model)
    {
        var user = await _userRepository.GetByEmailAsync(model.Email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            return null;

        return user;
    }
}
