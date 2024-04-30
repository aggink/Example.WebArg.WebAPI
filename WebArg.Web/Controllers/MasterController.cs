using Microsoft.AspNetCore.Mvc;
using WebArg.Web.DataAnnotations;
using WebArg.Web.Features.Masters.DtoModels;
using WebArg.Web.Features.Masters.Managers.Interfaces;
using WebArg.Web.Features.Masters.Queries;

namespace WebArg.Web.Controllers;

/// <summary>
/// Контроллер - мастера
/// </summary>
[Route("[controller]")]
[Produces("application/json")]
[ValidateUsingFluentValidation]
public class MasterController : Controller
{
    private readonly IMasterManager _masterManager;

    public MasterController(IMasterManager masterManager)
    {
        _masterManager = masterManager;
    }

    /// <summary>
    /// Получить список мастеров
    /// </summary>
    /// <returns>Список мастеров</returns>
    [HttpGet(nameof(GetListMaster), Name = nameof(GetListMaster))]
    public async Task<ActionResult<MasterDto[]>> GetListMaster()
    {
        var list = await _masterManager.GetListMasterAsync();
        return Ok(list);
    }

    /// <summary>
    /// Получить полную информацию о мастере
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полная информация о мастере</returns>
    [HttpGet(nameof(GetInfoMaster), Name = nameof(GetInfoMaster))]
    public async Task<ActionResult<InfoMasterDto>> GetInfoMaster(GetInfoMasterQuery query, CancellationToken cancellationToken)
    {
        var model = await _masterManager.GetInfoMasterAsync(query.IsnMaster, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Получить данные мастера для редактирования
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные мастера для редактирования</returns>
    [HttpGet(nameof(GetEditMaster), Name = nameof(GetEditMaster))]
    public async Task<ActionResult<EditMasterDto>> GetEditMaster(GetEditMasterQuery query, CancellationToken cancellationToken)
    {
        var model = await _masterManager.GetMasterAsync(query.IsnMaster, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Создать мастера
    /// </summary>
    /// <param name="model">Мастер</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(CreateMaster), Name = nameof(CreateMaster))]
    public async Task<ActionResult> CreateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
    {
        await _masterManager.CreateMasterAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Обновить данные мастера
    /// </summary>
    /// <param name="model">Мастер</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPut(nameof(UpdateMaster), Name = nameof(UpdateMaster))]
    public async Task<ActionResult> UpdateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
    {
        await _masterManager.UpdateMasterAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удалить мастера
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteMaster), Name = nameof(DeleteMaster))]
    public async Task<ActionResult> DeleteMaster(DeleteMasterQuery query, CancellationToken cancellationToken)
    {
        await _masterManager.DeleteMasterAsync(query.IsnMaster, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Установить связь между мастером и клиентом
    /// </summary>
    /// <param name="model">Настройка связи между мастером и клиентом</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(SetBindWithPerson), Name = nameof(SetBindWithPerson))]
    public async Task<ActionResult> SetBindWithPerson([FromBody] SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterManager.SetBindWithPersonAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удалить связь между мастером и клиентом 
    /// </summary>
    /// <param name="model">Настройка связи между мастером и клиентом</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteBindWithPerson), Name = nameof(DeleteBindWithPerson))]
    public async Task<ActionResult> DeleteBindWithPerson([FromBody] SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterManager.DeleteBindWithPersonAsync(model, cancellationToken);
        return Ok();
    }
}
