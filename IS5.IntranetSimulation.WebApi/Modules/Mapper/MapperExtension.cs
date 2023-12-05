using IS5.IntranetSimulation.WebApi.CrossLayer.Mapper;

namespace IS5.IntranetSimulation.WebApi.Modules.Mapper
{
    public static class MapperExtension
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));
            return services;
        }
    }
}
