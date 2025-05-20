using MyAuthApp.Models;

namespace MyAuthApp.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task AddUserAsync(User user);
    Task<bool> UserExistsAsync(string email);
}
