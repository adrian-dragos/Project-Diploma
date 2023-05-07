using WebApi.Middlewares;

public static class WebApiService
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        var assembly = typeof(WebApiService).Assembly;

        services.AddAutoMapper(assembly);

        services.AddTransient<ExceptionHandler>();

        services.AddCors(o =>
        {
            o.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

        return services;
    }
}