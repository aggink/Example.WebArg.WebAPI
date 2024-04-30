using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.Interfaces;

public interface IPersonManager
{
    Task CreatePersonAsync(EditPersonDto source, CancellationToken cancellationToken);

    Task UpdatePersonAsync(EditPersonDto source, CancellationToken cancellationToken);

    Task<PersonDto> DeletePersonAsync(Guid isnPerson, CancellationToken cancellationToken);

    Task<EditPersonDto> GetPersonAsync(Guid isnPerson, CancellationToken cancellationToken);

    Task<PersonDto[]> GetListPersonAsync(Guid? isnStudio);

    Task<InfoPersonDto> GetInfoPersonAsync(Guid isnPerson, CancellationToken cancellationToken);
}
