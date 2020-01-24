using Microsoft.Extensions.DependencyInjection;
using University_Management_System_API.Business.Convertor.EducationalDegree;
using University_Management_System_API.Business.Processor.EducationalDegree;
using University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree;

namespace University_Management_System_API.Extensions.EducationalDegree
{
    public static class RegisterEducationalDegreeExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IEducationalDegreeStorage, EducationalDegreeStorage>();
            //services.AddTransient<IEducationalDegreeDao, EducationalDegreeDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IEducationalDegreeDao, EducationalDegreeDaoEF>();

            services.AddTransient<IEducationalDegreeParamConverter, EducationalDegreeParamConverter>();
            services.AddTransient<IEducationalDegreeResultConverter, EducationalDegreeResultConverter>();

            services.AddTransient<IEducationalDegreeProcessor, EducationalDegreeProcessor>();
        }
    }
}
