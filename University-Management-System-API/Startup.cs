using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using University_Management_System_API.Swagger;
using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.Extensions.Common;
using University_Management_System_API.Authentication.Common;

namespace University_Management_System_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Secrete key
            var SaltSettingsSercret = Configuration.GetSection("SecretKeySettings");
                services.Configure<SecretKeySettings>(SaltSettingsSercret);

            services.AddControllers();

            services.AddDbContext<UniversityManagementSystemContext>(options =>
                options.UseSqlServer(Configuration
                .GetConnectionString("University-Management-System-Default")
                ).UseLazyLoadingProxies());

            // Injection of all objects
            BaseRegisterExtensions.BaseRegisterDependencies(services);

            //... rest of services configuration
            services.AddSwaggerDocumentation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerServiceExtensions.UseSwaggerDocumentation(app);

            app.UseHttpsRedirection();

            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            //Authentication
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });           
        }
    }
}
