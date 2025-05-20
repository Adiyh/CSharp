using MyAuthApp.DTOs;
using MyAuthApp.Models;

namespace MyAuthApp.Services.Interfaces;

public interface IAuthService
{
    Task<bool> RegisterAsync(RegisterModel model);
    Task<User?> LoginAsync(LoginModel model);
}
