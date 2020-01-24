using Microsoft.AspNetCore.Builder;

namespace University_Management_System_API.Swagger
{
    public static class ConfigureSwagger
    {
        public static void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            app.UseDeveloperExceptionPage();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "University Management System");
            });
        }
    }
}
