using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.Authentication.AuthenticationHendler;
using University_Management_System_API.Authentication.AuthenticationProvider;
using University_Management_System_API.Authentication.AuthenticationProvider.BasicAuth;
using University_Management_System_API.Authentication.AuthenticationProvider.TokenAuth;

namespace University_Management_System_API.Extensions.Authentication
{
    public static class RegisterAuthenticationProviderExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBasicAuthenticationProvider, BasicAuthenticationProvider>();

            services.AddScoped<ITokenAuthenticationProvider, TokenAuthenticationProvider>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }
    }
}
