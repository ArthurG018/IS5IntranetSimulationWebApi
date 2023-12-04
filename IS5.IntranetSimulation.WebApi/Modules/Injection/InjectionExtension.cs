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

            services.AddScoped<IDocenteRepository, DocenteRepository>();
            services.AddScoped<IDocenteDomain, DocenteDomain>();

            services.AddScoped<IEstudianteRepository, EstudianteRepository>();
            services.AddScoped<IEstudianteDomain, EstudianteDomain>();

            return services;
        }
    }
}
