using Microsoft.OpenApi.Models;
using System.Reflection;
using WebArg.Logic.Extensions;
using WebArg.Web.Features.Interfaces;
using WebArg.Web.Features.Managers;
using WebArg.Web.Features.Mappers;

namespace WebArg.Web.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов Web
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddFeaturesServices(this IServiceCollection services)
    {
        services.AddTransient<IStudioManager, StudioManager>();
        services.AddTransient<IPersonManager, PersonManager>();
        services.AddTransient<IMasterManager, MasterManager>();

        services.AddAutoMappers();
        services.AddLogicServices();
    }

    /// <summary>
    /// Регистрация mappers
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddAutoMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(
            typeof(StudioMapper),
            typeof(PersonMapper),
            typeof(MasterMapper));
    }

    /// <summary>
    /// Регистрация Swagger
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddSwaggerSetup(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Web", Version = "v1" });
            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            foreach (FileInfo file in new DirectoryInfo(AppContext.BaseDirectory).GetFiles(
                         Assembly.GetExecutingAssembly().GetName().Name! + ".xml"))
                c.IncludeXmlComments(file.FullName);

            c.EnableAnnotations(enableAnnotationsForInheritance: true,
                enableAnnotationsForPolymorphism: true
            );
        });
    }
}
