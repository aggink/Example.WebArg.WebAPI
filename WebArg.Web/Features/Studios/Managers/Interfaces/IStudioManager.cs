using WebArg.Web.Features.Studios.DtoModels;

namespace WebArg.Web.Features.Studios.Managers.Interfaces;

/// <summary>
/// Интерфейс обработчика <see cref="Studio"/>
/// </summary>
public interface IStudioManager
{
    /// <summary>
    /// Создать студию
    /// </summary>
    /// <param name="source">Студия</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task CreateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить данные студии
    /// </summary>
    /// <param name="source">Студия</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task UpdateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

    /// <summary>
    /// Удалить студию
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task DeleteStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>
    /// Получить студию
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Студия</returns>
    Task<EditStudioDto> GetStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>Установить связь между студией и мастером
    /// 
    /// </summary>
    /// <param name="model">Связь между студией и мастером</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task SetBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

    /// <summary>
    /// Удалить связь между студией и мастером
    /// </summary>
    /// <param name="model">Связь между студией и мастером</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные об операции</returns>
    Task DeleteBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

    /// <summary>
    /// Получить полные данные о студии
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полные данные о студии</returns>
    Task<InfoStudioDto> GetInfoStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>
    /// Получить список студий
    /// </summary>
    /// <returns>Список студий</returns>
    Task<StudioDto[]> GetListStudioAsync();
}
