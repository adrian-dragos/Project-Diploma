using WebApi.Middlewares;

public static class WebApiService
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {

        services.AddControllers()
            .AddNewtonsoftJson();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerDocument(option =>
            option.Title = "DrivingSchoolAPI");

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