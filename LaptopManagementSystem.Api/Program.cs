using LaptopService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using LaptopService.Infrastructure.Repositories.Interface;
using LaptopService.Infrastructure.Repositories.ConcreteClass;
using Microsoft.Extensions.DependencyInjection; // Ensure this is included
using Microsoft.Extensions.Configuration; // Ensure this is included
using LaptopService.Core.Services.Interface;
using LaptopService.Core.Services.ConcreteClass;


// Add to builder.Services:

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ILaptopService, LaptopServices>();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILaptopRepository, LaptopRepository>();

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Ensure Microsoft.EntityFrameworkCore.SqlServer is installed


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

