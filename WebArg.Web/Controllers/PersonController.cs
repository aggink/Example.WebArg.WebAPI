using Microsoft.AspNetCore.Mvc;
using WebArg.Web.DataAnnotations;
using WebArg.Web.Features.Persons.DtoModels;
using WebArg.Web.Features.Persons.Managers.Interfaces;
using WebArg.Web.Features.Persons.Queries;

namespace WebArg.Web.Controllers;

/// <summary>
/// Контроллер - клиент
/// </summary>
[Route("[controller]")]
[Produces("application/json")]
[ValidateUsingFluentValidation]
public class PersonController : Controller
{
    private readonly IPersonManager _personManager;

    public PersonController(IPersonManager personManager)
    {
        _personManager = personManager;
    }

    /// <summary>
    /// Получить список клиентов
    /// </summary>
    /// <returns>Список клиентов</returns>
    [HttpGet(nameof(GetListPerson), Name = nameof(GetListPerson))]
    public async Task<ActionResult<PersonDto[]>> GetListPerson()
    {
        var list = await _personManager.GetListPersonAsync(null);
        return Ok(list);
    }

    /// <summary>
    /// Получить полную информацию о клиенте
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Полная информация о клиенте</returns>
    [HttpGet(nameof(GetInfoPerson), Name = nameof(GetInfoPerson))]
    public async Task<ActionResult<InfoPersonDto>> GetInfoPerson(GetInfoPersonQuery query, CancellationToken cancellationToken)
    {
        var model = await _personManager.GetInfoPersonAsync(query.IsnPerson, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Получить данные клиента для редактирования
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные клиента для редактирования</returns>
    [HttpGet(nameof(GetEditPerson), Name = nameof(GetEditPerson))]
    public async Task<ActionResult<EditPersonDto>> GetEditPerson(GetEditPersonQuery query, CancellationToken cancellationToken)
    {
        var model = await _personManager.GetPersonAsync(query.IsnPerson, cancellationToken);
        return Ok(model);
    }

    /// <summary>
    /// Создать клиента
    /// </summary>
    /// <param name="model">Клиент</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(CreateРerson), Name = nameof(CreateРerson))]
    public async Task<ActionResult> CreateРerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
    {
        await _personManager.CreatePersonAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Обновить данные клиента
    /// </summary>
    /// <param name="model">Клиент</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPut(nameof(UpdatePerson), Name = nameof(UpdatePerson))]
    public async Task<ActionResult> UpdatePerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
    {
        await _personManager.UpdatePersonAsync(model, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удалить клиента
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteРerson), Name = nameof(DeleteРerson))]
    public async Task<ActionResult> DeleteРerson(DeleteРersonQuery query, CancellationToken cancellationToken)
    {
        await _personManager.DeletePersonAsync(query.IsnPerson, cancellationToken);
        return Ok();
    }
}
