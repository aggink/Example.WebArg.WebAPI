using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Person;
using WebArg.Web.Features.DtoModels.Studio;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManageController : Controller
    {
        // todo: лучше разбить на три контроллера, каждый из которых будет подтягивать свой manager, НО для упрощения и так сойдет
        // todo: так как это веб-приложение представляет собой api, следует добавить middleware для глобальной обработки ошибок
        private readonly IStudioManager _studioManager;
        private readonly IMasterManager _masterManager;
        private readonly IPersonManager _personManager;

        public const string Manage = "Manage";

        public ManageController(
            IStudioManager studioManager,
            IMasterManager trainerManager,
            IPersonManager personManager)
        {
            _studioManager = studioManager;
            _masterManager = trainerManager;
            _personManager = personManager;
        }

        #region Studio

        [HttpGet(nameof(GetListStudios), Name = nameof(GetListStudios))]
        public async Task<ActionResult<StudioDto[]>> GetListStudios()
        {
            var list = await _studioManager.GetListStudioAsync();

            return Ok(list);
        }

        [HttpGet(nameof(GetInfoStudio), Name = nameof(GetInfoStudio))]
        public async Task<ActionResult<InfoStudioDto>> GetInfoStudio([FromQuery, Required] Guid isnStudio)
        {
            var model = await _studioManager.GetInfoStudioAsync(isnStudio);
            return Ok(model);
        }

        [HttpGet(nameof(GetStudio), Name = nameof(GetStudio))]
        public async Task<ActionResult<EditStudioDto>> GetStudio([FromQuery, Required] Guid isnStudio)
        {
            var model = await _studioManager.GetStudioAsync(isnStudio);

            return Ok(model);
        }

        [HttpPost(nameof(CreateStudio), Name = nameof(CreateStudio))]
        public async Task<ActionResult> CreateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

            await _studioManager.CreateStudioAsync(model, cancellationToken);

            return Ok();
        }

        [HttpPut(nameof(UpdateStudio), Name = nameof(UpdateStudio))]
        public async Task<ActionResult> UpdateStudio([FromBody] EditStudioDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

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
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _studioManager.SetBindWithMasterAsync(model, cancellationToken);

            return Ok();
        }


        [HttpDelete(nameof(DeleteBindWithMaster), Name = nameof(DeleteBindWithMaster))]
        public async Task<ActionResult> DeleteBindWithMaster([FromBody] SetBindWithMasterDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _studioManager.DeleteBindWithMasterAsync(model, cancellationToken);

            return Ok();
        }

        #endregion

        #region Master 

        [HttpGet(nameof(GetListMaster), Name = nameof(GetListMaster))]
        public async Task<ActionResult<MasterDto[]>> GetListMaster()
        {
            var list = await _masterManager.GetListMasterAsync();

            return Ok(list);
        }

        [HttpGet(nameof(GetInfoMaster), Name = nameof(GetInfoMaster))]
        public async Task<ActionResult<InfoMasterDto>> GetInfoMaster([FromQuery, Required] Guid isnMaster)
        {
            var model = await _masterManager.GetInfoMasterAsync(isnMaster);

            return Ok(model);
        }

        [HttpGet(nameof(GetEditMaster), Name = nameof(GetEditMaster))]
        public async Task<ActionResult<EditMasterDto>> GetEditMaster([FromQuery, Required] Guid isnMaster)
        {
            var model = await _masterManager.GetMasterAsync(isnMaster);

            return Ok(model);
        }

        [HttpPost(nameof(CreateMaster), Name = nameof(CreateMaster))]
        public async Task<ActionResult> CreateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

            await _masterManager.CreateMasterAsync(model, cancellationToken);

            return Ok();
        }

        [HttpPut(nameof(UpdateMaster), Name = nameof(UpdateMaster))]
        public async Task<ActionResult> UpdateMaster([FromBody] EditMasterDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

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
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _masterManager.SetBindWithPersonAsync(model, cancellationToken);

            return Ok();
        }


        [HttpDelete(nameof(DeleteBindWithPerson), Name = nameof(DeleteBindWithPerson))]
        public async Task<ActionResult> DeleteBindWithPerson([FromBody] SetBindWithPersonDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _masterManager.DeleteBindWithPersonAsync(model, cancellationToken);

            return Ok();
        }

        #endregion

        #region Customer

        [HttpGet(nameof(GetListPerson), Name = nameof(GetListPerson))]
        public async Task<ActionResult<PersonDto[]>> GetListPerson()
        {
            var list = await _personManager.GetListРersonAsync(null);

            return Ok(list);
        }

        [HttpGet(nameof(GetInfoPerson), Name = nameof(GetInfoPerson))]
        public async Task<ActionResult<InfoPersonDto>> GetInfoPerson([FromQuery, Required] Guid isnPerson)
        {
            var model = await _personManager.GetInfoPersonAsync(isnPerson);

            return Ok(model);
        }

        [HttpGet(nameof(GetEditPerson), Name = nameof(GetEditPerson))]
        public async Task<ActionResult<EditPersonDto>> GetEditPerson([FromQuery, Required] Guid isnPerson)
        {
            var model = await _personManager.GetРersonAsync(isnPerson);

            return Ok(model);
        }

        [HttpPost(nameof(CreateРerson), Name = nameof(CreateРerson))]
        public async Task<ActionResult> CreateРerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

            await _personManager.CreateРersonAsync(model, cancellationToken);

            return Ok();
        }

        [HttpPut(nameof(UpdateРerson), Name = nameof(UpdateРerson))]
        public async Task<ActionResult> UpdateРerson([FromBody] EditPersonDto model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(model);

            await _personManager.UpdateРersonAsync(model, cancellationToken);

            return Ok();
        }

        [HttpDelete(nameof(DeleteРerson), Name = nameof(DeleteРerson))]
        public async Task<ActionResult> DeleteРerson([FromBody, Required] Guid isnPerson, CancellationToken cancellationToken)
        {
            var model = await _personManager.DeleteРersonAsync(isnPerson, cancellationToken);

            return Ok();
        }

        #endregion
    }
}
