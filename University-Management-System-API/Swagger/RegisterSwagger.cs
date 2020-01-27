using System.Linq;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.IO;
using System;

namespace University_Management_System_API.Swagger
{
    public static class RegisterSwagger
    {
        public static void ConfigureSwagger(IServiceCollection services)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "University Management System",
                    Description = "University Management System of .NET Core Web API .",
                    Contact = new OpenApiContact
                    {
                        Name = "Georgi Karagyozov",
                        Email = "georgi.karagyozov@kodar.net",
                        Url = new Uri("https://github.com/GeorgiKaragyozov")
                    }
                });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                          new string[] {}
                    }
                });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                //// Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);
            });        
        }
    }
}
