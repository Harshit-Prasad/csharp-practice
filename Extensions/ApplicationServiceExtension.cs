using Microsoft.EntityFrameworkCore;
using social_media_api.Data;
using social_media_api.Interfaces;
using social_media_api.Services;

namespace social_media_api.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicatoinServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("Default"));
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
