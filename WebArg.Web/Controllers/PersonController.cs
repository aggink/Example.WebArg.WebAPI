using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Person;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Controllers;

public class PersonController : Controller
{
    private readonly IPersonManager _personManager;

    public PersonController(IPersonManager personManager)
    {
        _personManager = personManager;
    }

    [HttpGet(nameof(GetListPerson), Name = nameof(GetListPerson))]
    public async Task<ActionResult<PersonDto[]>> GetListPerson(CancellationToken cancellationToken)
    {
        var list = await _personManager.GetListPersonAsync(null);
        return Ok(list);
    }

    [HttpGet(nameof(GetInfoPerson), Name = nameof(GetInfoPerson))]
    public async Task<ActionResult<InfoPersonDto>> GetInfoPerson([FromQuery, Required] Guid isnPerson, CancellationToken cancellationToken)
    {
        var model = await _personManager.GetInfoPersonAsync(isnPerson, cancellationToken);
        return Ok(model);
    }

    [HttpGet(nameof(GetEditPerson), Name = nameof(GetEditPerson))]
    public async Task<ActionResult<EditPersonDto>> GetEditPerson([FromQuery, Required] Guid isnPerson, CancellationToken cancellationToken)
    {
        var model = await _personManager.GetPersonAsync(isnPerson, cancellationToken);
        return Ok(model);
    }

    [HttpPost(nameof(CreateРerson), Name = nameof(CreateРerson))]
    public async Task<ActionResult> CreateРerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
    {
        await _personManager.CreatePersonAsync(model, cancellationToken);
        return Ok();
    }

    [HttpPut(nameof(UpdatePerson), Name = nameof(UpdatePerson))]
    public async Task<ActionResult> UpdatePerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
    {
        await _personManager.UpdatePersonAsync(model, cancellationToken);
        return Ok();
    }

    [HttpDelete(nameof(DeleteРerson), Name = nameof(DeleteРerson))]
    public async Task<ActionResult> DeleteРerson([FromBody, Required] Guid isnPerson, CancellationToken cancellationToken)
    {
        await _personManager.DeletePersonAsync(isnPerson, cancellationToken);
        return Ok();
    }
}
