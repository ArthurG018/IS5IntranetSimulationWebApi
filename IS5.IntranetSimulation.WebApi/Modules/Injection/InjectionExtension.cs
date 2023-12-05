using IS5.IntranetSimulation.WebApi.AplicationLayer.Interface;
using IS5.IntranetSimulation.WebApi.ApplicationLayer.Interface;
using IS5.IntranetSimulation.WebApi.ApplicationLayer.Main;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Core;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Data;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository;

namespace IS5.IntranetSimulation.WebApi.Modules.Injection
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            services.AddSingleton<IConnectionDataBase, ConnectionDataBase>();

            services.AddScoped<IProfesorApplication, ProfessorApplication>();
            services.AddScoped<IProfessorDomain, ProfessorDomain>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();

            services.AddScoped<IStudentApplication, StudentApplication>();
            services.AddScoped<IStudentDomain, StudentDomain>();
            services.AddScoped<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
