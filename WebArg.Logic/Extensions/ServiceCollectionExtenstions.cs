using Microsoft.Extensions.DependencyInjection;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Logic.Interfaces.Services;
using WebArg.Logic.Repositories;
using WebArg.Logic.Services;
using WebArg.Storage.Models;

namespace WebArg.Logic.Extensions
{
    public static class ServiceCollectionExtenstions
    {
        public static void AddLogicServices(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Studio>, StudioRepository>();
            services.AddSingleton<IRepository<Master>, MasterRepository>();
            services.AddSingleton<IRepository<Person>, PersonRepository>();

            services.AddSingleton<IPersonService, PersonService>();
            services.AddSingleton<IStudioService, StudioService>();
            services.AddSingleton<IMasterService, MasterService>();
        }
    }
}
