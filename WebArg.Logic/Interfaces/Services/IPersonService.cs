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
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <returns>Получить список клиентов</returns>
    IQueryable<Person> GetPersonQueryable(DataContext dataContext, Guid? isnStudio);

    /// <summary>
    /// Получить информацию о клиенте
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnPerson">Идентификатор клиента</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Информация о клиенте</returns>
    Task<Person> GetInfoPersonAsync(DataContext dataContext, Guid isnPerson, CancellationToken cancellationToken);
}
