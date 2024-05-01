using Microsoft.AspNetCore.Mvc;
using WebArg.Web.DataAnnotations;
using WebArg.Web.Features.Studios.DtoModels;
using WebArg.Web.Features.Studios.Managers.Interfaces;
using WebArg.Web.Features.Studios.Queries;
using X.PagedList;

namespace WebArg.Web.Controllers;

/// <summary>
/// Контроллер - студия
/// </summary>
[Route("[controller]")]
[Produces("application/json")]
[ValidateUsingFluentValidation]
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
    /// <param name="query">Dto параметр</param>
    /// <returns>Список студий</returns>
    [HttpGet(nameof(GetListStudios), Name = nameof(GetListStudios))]
    public async Task<ActionResult<IPagedList<StudioDto>>> GetListStudios(GetListStudiosQuery query)
    {
        var list = await _studioManager.GetListStudioAsync(query);
        return Ok(list);
    }

    /// <summary>
    /// Получить полную информацию о студии
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полная информация о студии</returns>
    [HttpGet(nameof(GetInfoStudio), Name = nameof(GetInfoStudio))]
    public async Task<ActionResult<InfoStudioDto>> GetInfoStudio(GetInfoStudioQuery query, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetInfoStudioAsync(query.IsnStudio, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Получить данные о студии
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные о студии</returns>
    [HttpGet(nameof(GetEditStudio), Name = nameof(GetEditStudio))]
    public async Task<ActionResult<EditStudioDto>> GetEditStudio(GetEditStudioQuery query, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetStudioAsync(query.IsnStudio, cancellationToken);
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
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteStudio), Name = nameof(DeleteStudio))]
    public async Task<ActionResult> DeleteStudio(DeleteStudioQuery query, CancellationToken cancellationToken)
    {
        await _studioManager.DeleteStudioAsync(query.IsnStudio, cancellationToken);
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
