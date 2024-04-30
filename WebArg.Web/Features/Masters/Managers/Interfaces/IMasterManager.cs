using WebArg.Web.Features.Masters.DtoModels;

namespace WebArg.Web.Features.Masters.Managers.Interfaces;

/// <summary>
/// Интерфейс обработчика <see cref="Master"/>
/// </summary>
public interface IMasterManager
{
    /// <summary>
    /// Создание мастера
    /// </summary>
    /// <param name="source">Мастер</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task CreateMasterAsync(EditMasterDto source, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить данные мастера
    /// </summary>
    /// <param name="source">Мастер</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task UpdateMasterAsync(EditMasterDto source, CancellationToken cancellationToken);

    /// <summary>
    /// Удалить мастера
    /// </summary>
    /// <param name="isnMaster">Идентификатор матера</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task DeleteMasterAsync(Guid isnMaster, CancellationToken cancellationToken);

    /// <summary>
    /// Получить данные мастера
    /// </summary>
    /// <param name="isnMaster">Идентификатор мастера</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные мастера</returns>
    Task<EditMasterDto> GetMasterAsync(Guid isnMaster, CancellationToken cancellationToken);

    /// <summary>
    /// Установить связь между мастером и клиентом
    /// </summary>
    /// <param name="model">Модель связи</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task SetBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken);

    /// <summary>
    /// Удалить связь между мастером и клиентом
    /// </summary>
    /// <param name="model">Модель связи</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task DeleteBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken);

    /// <summary>
    /// Получить список мастеров
    /// </summary>
    /// <returns>Список мастеров</returns>
    Task<MasterDto[]> GetListMasterAsync();

    /// <summary>
    /// Получить полную информацию о мастере
    /// </summary>
    /// <param name="isnMaster">Идентификатор мастера</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полная информация о мастере</returns>
    Task<InfoMasterDto> GetInfoMasterAsync(Guid isnMaster, CancellationToken cancellationToken);
}
