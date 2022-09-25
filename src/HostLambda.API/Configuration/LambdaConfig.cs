namespace HostLambda.API.Configuration;

public static class LambdaConfig
{
    public static IServiceCollection AddLambdaConfiguration(this IServiceCollection services)
    {
        services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

        return services;
    }
}