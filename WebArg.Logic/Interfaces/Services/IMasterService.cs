using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services;

/// <summary>
/// Сервис для модели <see cref="Master"/>
/// </summary>
public interface IMasterService
{
    /// <summary>
    /// Установить связь между мастером и клиентом
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnMaster">Идентификатор мастера</param>
    /// <param name="isnPerson">Идентификатор клиента</param>
    Task SetBindWithPersonAsync(DataContext dataContext, Guid isnMaster, Guid isnPerson);

    /// <summary>
    /// Удалить связь мастером и клиента
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnMaster">Идентификатор мастера</param>
    /// <param name="isnPerson">Идентификатор клиента</param>
    Task DeleteBindWithPersonAsync(DataContext dataContext, Guid isnMaster, Guid isnPerson);

    /// <summary>
    /// Получить список мастеров
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <returns>Список мастеров</returns>
    IQueryable<Master> GetMasterQueryable(DataContext dataContext);

    /// <summary>
    /// Получить информацию о мастере
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnMaster">Идентификатор матера</param>
    /// <returns>Информация о мастере</returns>
    Task<Master> GetInfoMasterAsync(DataContext dataContext, Guid isnMaster);
}
