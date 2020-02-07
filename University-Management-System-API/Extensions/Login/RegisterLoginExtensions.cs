using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.Business.Processor.Login;

namespace University_Management_System_API.Extensions.Login
{
    public static class RegisterLoginExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddTransient<ILoginProcessor, LoginProcessor>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
