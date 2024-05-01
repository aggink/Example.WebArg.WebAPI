using WebArg.Logic.DtoModels;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services;

/// <summary>
/// Сервис для модели <see cref="Person"/>
/// </summary>
public interface IPersonService
{
    /// <summary>
    /// Список клиентов
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="filter">Фильтры</param>
    /// <returns>Получить список клиентов</returns>
    IQueryable<Person> GetPersonQueryable(DataContext dataContext, PersonFilter filter);

    /// <summary>
    /// Получить информацию о клиенте
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnPerson">Идентификатор клиента</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Информация о клиенте</returns>
    Task<Person> GetInfoPersonAsync(DataContext dataContext, Guid isnPerson, CancellationToken cancellationToken);
}
