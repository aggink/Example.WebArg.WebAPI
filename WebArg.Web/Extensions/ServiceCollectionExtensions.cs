using Microsoft.Extensions.DependencyInjection;
using WebArg.Web.Features.Interfaces;
using WebArg.Web.Features.Managers;
using WebArg.Web.Features.Mappers;

namespace WebArg.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFeaturesServices(this IServiceCollection services)
        {
            services.AddTransient<IStudioManager, StudioManager>();
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IMasterManager, MasterManager>();
        }

        public static void AddAutoMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(StudioMapper),
                typeof(PersonMapper),
                typeof(MasterMapper));
        }
    }
}
