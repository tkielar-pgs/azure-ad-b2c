using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace PGS.Azure.ActiveDirectory.B2C.Auth
{
    public static class AzureAdServiceCollectionExtensions
    {
        public static IServiceCollection ConfiguraAzureAdOpenId(this IServiceCollection serviceCollection) =>
            serviceCollection.AddSingleton<IConfigureOptions<OpenIdConnectOptions>, ConfigureAzureAdOpenIdOptions>();
    }
}