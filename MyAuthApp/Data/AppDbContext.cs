using Microsoft.EntityFrameworkCore;
using MyAuthApp.Models;

namespace MyAuthApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
}
