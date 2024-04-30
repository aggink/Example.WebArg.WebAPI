using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Studio;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Controllers;

/// <summary>
/// Контроллер - студия
/// </summary>
public class StudioController : Controller
{
    private readonly IStudioManager _studioManager;

    public StudioController(IStudioManager studioManager)
    {
        _studioManager = studioManager;
    }

    /// <summary>
    /// Получить список студий
    /// </summary>
    /// <returns>Список студий</returns>
    [HttpGet(nameof(GetListStudios), Name = nameof(GetListStudios))]
    public async Task<ActionResult<StudioDto[]>> GetListStudios()
    {
        var list = await _studioManager.GetListStudioAsync();
        return Ok(list);
    }

    /// <summary>
    /// Получить полную информацию о студии
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полная информация о студии</returns>
    [HttpGet(nameof(GetInfoStudio), Name = nameof(GetInfoStudio))]
    public async Task<ActionResult<InfoStudioDto>> GetInfoStudio([FromQuery, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetInfoStudioAsync(isnStudio, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Получить данные о студии
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные о студии</returns>
    [HttpGet(nameof(GetEditStudio), Name = nameof(GetEditStudio))]
    public async Task<ActionResult<EditStudioDto>> GetEditStudio([FromQuery, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetStudioAsync(isnStudio, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Создать студию
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(CreateStudio), Name = nameof(CreateStudio))]
    public async Task<ActionResult> CreateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
    {
        await _studioManager.CreateStudioAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Обновить данные студии
    /// </summary>
    /// <param name="model">Студия</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPut(nameof(UpdateStudio), Name = nameof(UpdateStudio))]
    public async Task<ActionResult> UpdateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
    {
        await _studioManager.UpdateStudioAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удалить студию
    /// </summary>
    /// <param name="isnStudio">Идентификатор студии</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteStudio), Name = nameof(DeleteStudio))]
    public async Task<ActionResult> DeleteStudio([FromBody, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        await _studioManager.DeleteStudioAsync(isnStudio, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Установить связь между студией и мастером
    /// </summary>
    /// <param name="model">Настройка связи студии с мастером</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(SetBindWithMaster), Name = nameof(SetBindWithMaster))]
    public async Task<ActionResult> SetBindWithMaster([FromBody] SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioManager.SetBindWithMasterAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удалить связь между студией и мастером
    /// </summary>
    /// <param name="model">Настройка связи студии с мастером</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteBindWithMaster), Name = nameof(DeleteBindWithMaster))]
    public async Task<ActionResult> DeleteBindWithMaster([FromBody] SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioManager.DeleteBindWithMasterAsync(model, cancellationToken);
        return Ok();
    }
}
