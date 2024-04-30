using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Studio;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Controllers;

public class StudioController : Controller
{
    private readonly IStudioManager _studioManager;

    public StudioController(IStudioManager studioManager)
    {
        _studioManager = studioManager;
    }

    [HttpGet(nameof(GetListStudios), Name = nameof(GetListStudios))]
    public async Task<ActionResult<StudioDto[]>> GetListStudios()
    {
        var list = await _studioManager.GetListStudioAsync();
        return Ok(list);
    }

    [HttpGet(nameof(GetInfoStudio), Name = nameof(GetInfoStudio))]
    public async Task<ActionResult<InfoStudioDto>> GetInfoStudio([FromQuery, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetInfoStudioAsync(isnStudio, cancellationToken);
        return Ok(model);
    }

    [HttpGet(nameof(GetStudio), Name = nameof(GetStudio))]
    public async Task<ActionResult<EditStudioDto>> GetStudio([FromQuery, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        var model = await _studioManager.GetStudioAsync(isnStudio, cancellationToken);
        return Ok(model);
    }

    [HttpPost(nameof(CreateStudio), Name = nameof(CreateStudio))]
    public async Task<ActionResult> CreateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
    {
        await _studioManager.CreateStudioAsync(model, cancellationToken);
        return Ok();
    }

    [HttpPut(nameof(UpdateStudio), Name = nameof(UpdateStudio))]
    public async Task<ActionResult> UpdateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
    {
        await _studioManager.UpdateStudioAsync(model, cancellationToken);
        return Ok();
    }

    [HttpDelete(nameof(DeleteStudio), Name = nameof(DeleteStudio))]
    public async Task<ActionResult> DeleteStudio([FromBody, Required] Guid isnStudio, CancellationToken cancellationToken)
    {
        await _studioManager.DeleteStudioAsync(isnStudio, cancellationToken);
        return Ok();
    }

    [HttpPost(nameof(SetBindWithMaster), Name = nameof(SetBindWithMaster))]
    public async Task<ActionResult> SetBindWithMaster([FromBody] SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioManager.SetBindWithMasterAsync(model, cancellationToken);
        return Ok();
    }


    [HttpDelete(nameof(DeleteBindWithMaster), Name = nameof(DeleteBindWithMaster))]
    public async Task<ActionResult> DeleteBindWithMaster([FromBody] SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioManager.DeleteBindWithMasterAsync(model, cancellationToken);
        return Ok();
    }
}
