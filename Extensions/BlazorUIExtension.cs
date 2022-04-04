namespace Extensions;

public static class BlazorUIExtension
{
    public static IServiceCollection AddBlazorUIExtension(this IServiceCollection services)
    {
        services.AddScoped<Navigation>();
        services.AddScoped<NavigationJSInterop>();
        services.AddScoped<IComponentService, ComponentService>();

        return services;
    }
}
