using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.Business.Processor.Auth;

namespace University_Management_System_API.Extensions.Auth
{
    public static class RegisterAuthExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAuthProcessor, AuthProcessor>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
