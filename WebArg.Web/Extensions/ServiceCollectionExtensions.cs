using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using WebArg.Logic.Extensions;
using WebArg.Storage.Database;
using WebArg.Web.Features.Masters.Managers;
using WebArg.Web.Features.Masters.Managers.Interfaces;
using WebArg.Web.Features.Masters.Mappers;
using WebArg.Web.Features.Persons.Managers;
using WebArg.Web.Features.Persons.Managers.Interfaces;
using WebArg.Web.Features.Persons.Mappers;
using WebArg.Web.Features.Studios.Managers;
using WebArg.Web.Features.Studios.Managers.Interfaces;
using WebArg.Web.Features.Studios.Mappers;

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

    /// <summary>
    /// Регистрация контекст базы данных
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="configuration">Набор свойств конфигурации</param>
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), o =>
        {
            o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        }));
    }

    /// <summary>
    /// Регистрация FluentValidation в DI
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="type">Глобальный тип для поиска валидаторов</param>
    public static void AddFluentValidationSetup(this IServiceCollection services, Type type)
    {
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssemblyContaining(type);

        ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;
        ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
    }
}
