using Application.Features.Services;
using Application.Features.Services.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configuration
{
    public static class ApplicationService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationService).Assembly;

            services.AddAutoMapper(assembly);

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();
            });

            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IPasswordService, PasswordService>();

            return services;
        }
    }
}
