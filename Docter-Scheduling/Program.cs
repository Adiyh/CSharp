using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Docter_Scheduling.Data;
using Docter_Scheduling.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Docter_Scheduling;

var customBuilder = CustomWebAppBuilder.CreateBuilder(args); // customBuilder is of type CustomWebAppBuilder

// Add services to the container.
customBuilder.Services.AddControllers();

customBuilder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(customBuilder.Configuration.GetConnectionString("DefaultConnection")));

customBuilder.Services.AddScoped<AppointmentService>();

var app = customBuilder.Build(); // app is of type WebApplication

// Configure the HTTP request pipeline.
if (customBuilder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
