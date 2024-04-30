using WebArg.Web.Features.DtoModels.Master;

namespace WebArg.Web.Features.Interfaces;

public interface IMasterManager
{
    Task CreateMasterAsync(EditMasterDto source, CancellationToken cancellationToken);

    Task UpdateMasterAsync(EditMasterDto source, CancellationToken cancellationToken);

    Task DeleteMasterAsync(Guid isnMaster, CancellationToken cancellationToken);

    Task<EditMasterDto> GetMasterAsync(Guid isnMaster, CancellationToken cancellationToken);

    Task SetBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken);

    Task DeleteBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken);

    Task<MasterDto[]> GetListMasterAsync();

    Task<InfoMasterDto> GetInfoMasterAsync(Guid isnMaster, CancellationToken cancellationToken);

}
