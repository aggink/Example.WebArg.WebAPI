using System;
using System.Threading;
using System.Threading.Tasks;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.Interfaces
{
    public interface IStudioManager
    {
        Task CreateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

        Task UpdateStudioAsync(EditStudioDto source, CancellationToken cancellationToken);

        Task DeleteStudioAsync(Guid isnStudio, CancellationToken cancellationToken);

        Task<EditStudioDto> GetStudioAsync(Guid isnStudio);

        Task SetBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

        Task DeleteBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken);

        Task<InfoStudioDto> GetInfoStudioAsync(Guid isnStudio);

        Task<StudioDto[]> GetListStudioAsync();
    }
}
