using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services;

/// <summary>
/// Сервис для <see cref="Studio"/>
/// </summary>
public interface IStudioService
{
    /// <summary>
    /// Связать студию с мастером
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="isnMaster">Идентификатор мастера</param>
    Task SetBindWithMasterAsync(DataContext dataContext, Guid isnStudio, Guid isnMaster);

    /// <summary>
    /// Удалить связь студии с мастером
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="isnMaster">Идентификатор мастера</param>
    Task DeleteBindWithMasterAsync(DataContext dataContext, Guid isnStudio, Guid isnMaster);

    /// <summary>
    /// Получить список студий
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <returns>Список студий</returns>
    IQueryable<Studio> GetStudioQueryable(DataContext dataContext);

    /// <summary>
    /// Получить информацию о студии
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <returns>Информация о студии</returns>
    Task<Studio> GetInfoStudioAsync(DataContext dataContext, Guid isnStudio);
}
