using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.BasicAuthentication.AuthenticationProvider;

namespace University_Management_System_API.Extensions.BasicAuthentication
{
    public static class RegisterAuthenticationProviderExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationProvider, AuthenticationProvider>();
        }
    }
}
