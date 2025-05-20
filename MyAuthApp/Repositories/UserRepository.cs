using Microsoft.EntityFrameworkCore;
using MyAuthApp.Data;
using MyAuthApp.Models;
using MyAuthApp.Repositories.Interfaces;

namespace MyAuthApp.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly AppDbContext _context = context;

    public async Task<User?> GetByEmailAsync(string email) =>
        await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

    public async Task AddUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UserExistsAsync(string email) =>
        await _context.Users.AnyAsync(u => u.Email == email);
}
