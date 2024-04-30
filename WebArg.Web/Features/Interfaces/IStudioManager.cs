using WebArg.Storage.Models;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.Interfaces;

/// <summary>
/// Интерфейс обработчика <see cref="Studio"/>
/// </summary>
public interface IStudioManager
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task CreateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isnStudio"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isnStudio"></param>
    /// <returns></returns>
    Task<EditStudioDto> GetStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SetBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isnStudio"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<InfoStudioDto> GetInfoStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<StudioDto[]> GetListStudioAsync();
}
