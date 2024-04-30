using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Controllers;

public class MasterController : Controller
{
    private readonly IMasterManager _masterManager;

    public MasterController(IMasterManager masterManager)
    {
        _masterManager = masterManager;
    }

    [HttpGet(nameof(GetListMaster), Name = nameof(GetListMaster))]
    public async Task<ActionResult<MasterDto[]>> GetListMaster()
    {
        var list = await _masterManager.GetListMasterAsync();
        return Ok(list);
    }

    [HttpGet(nameof(GetInfoMaster), Name = nameof(GetInfoMaster))]
    public async Task<ActionResult<InfoMasterDto>> GetInfoMaster([FromQuery, Required] Guid isnMaster, CancellationToken cancellationToken)
    {
        var model = await _masterManager.GetInfoMasterAsync(isnMaster, cancellationToken);
        return Ok(model);
    }

    [HttpGet(nameof(GetEditMaster), Name = nameof(GetEditMaster))]
    public async Task<ActionResult<EditMasterDto>> GetEditMaster([FromQuery, Required] Guid isnMaster, CancellationToken cancellationToken)
    {
        var model = await _masterManager.GetMasterAsync(isnMaster, cancellationToken);
        return Ok(model);
    }

    [HttpPost(nameof(CreateMaster), Name = nameof(CreateMaster))]
    public async Task<ActionResult> CreateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
    {
        await _masterManager.CreateMasterAsync(model, cancellationToken);
        return Ok();
    }

    [HttpPut(nameof(UpdateMaster), Name = nameof(UpdateMaster))]
    public async Task<ActionResult> UpdateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
    {
        await _masterManager.UpdateMasterAsync(model, cancellationToken);
        return Ok();
    }

    [HttpDelete(nameof(DeleteMaster), Name = nameof(DeleteMaster))]
    public async Task<ActionResult> DeleteMaster([FromBody, Required] Guid isnMaster, CancellationToken cancellationToken)
    {
        await _masterManager.DeleteMasterAsync(isnMaster, cancellationToken);
        return Ok();
    }

    [HttpPost(nameof(SetBindWithPerson), Name = nameof(SetBindWithPerson))]
    public async Task<ActionResult> SetBindWithPerson([FromBody] SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterManager.SetBindWithPersonAsync(model, cancellationToken);
        return Ok();
    }


    [HttpDelete(nameof(DeleteBindWithPerson), Name = nameof(DeleteBindWithPerson))]
    public async Task<ActionResult> DeleteBindWithPerson([FromBody] SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterManager.DeleteBindWithPersonAsync(model, cancellationToken);
        return Ok();
    }
}
