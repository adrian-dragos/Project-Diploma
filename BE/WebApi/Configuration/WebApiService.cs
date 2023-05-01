public static class WebApiService
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        var assembly = typeof(WebApiService).Assembly;

        services.AddAutoMapper(assembly);

        return services;
    }
}