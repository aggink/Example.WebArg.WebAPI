using System;
using System.Threading;
using System.Threading.Tasks;
using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.Interfaces
{
    public interface IPersonManager
    {
        Task CreateРersonAsync(EditPersonDto source, CancellationToken cancellationToken);

        Task UpdateРersonAsync(EditPersonDto source, CancellationToken cancellationToken);

        Task<PersonDto> DeleteРersonAsync(Guid isnPerson, CancellationToken cancellationToken);

        Task<EditPersonDto> GetРersonAsync(Guid isnPerson);

        Task<PersonDto[]> GetListРersonAsync(Guid? isnStudio);

        Task<InfoPersonDto> GetInfoPersonAsync(Guid isnPerson);
    }
}
