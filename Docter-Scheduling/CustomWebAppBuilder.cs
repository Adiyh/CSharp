using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

 namespace Docter_Scheduling

{
    internal class CustomWebAppBuilder
    {
        private readonly WebApplicationBuilder _builder;

        private CustomWebAppBuilder(WebApplicationBuilder builder)
        {
            _builder = builder;
        }

        public static CustomWebAppBuilder CreateBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            return new CustomWebAppBuilder(builder);
        }

        public IServiceCollection Services => _builder.Services;

        public IConfiguration Configuration => _builder.Configuration;

        public IHostEnvironment Environment => _builder.Environment;

        public WebApplication Build()
        {
            return _builder.Build();
        }
    }
}
