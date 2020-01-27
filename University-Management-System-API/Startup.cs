using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using University_Management_System_API.Extensions.Common;
using University_Management_System_API.Swagger;
using Microsoft.AspNetCore.Authentication;
using University_Management_System_API.Handlers;

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
            services.AddControllers();

            services.AddDbContext<UniversityManagementSystemContext>(options => 
                options.UseSqlServer(
                    @"Server=.;Database=University-Management-System-API-DB;Integrated Security = True"));

            // Injection of all objects
            BaseRegisterExtensions.BaseRegisterDependencies(services);

            //Register swagger
            RegisterSwagger.ConfigureSwagger(services);

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Swagger
            ConfigureSwagger.Configure(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

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
