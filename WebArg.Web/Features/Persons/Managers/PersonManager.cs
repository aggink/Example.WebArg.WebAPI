using AutoMapper;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;
using WebArg.Web.Features.Masters.DtoModels;
using WebArg.Web.Features.Persons.DtoModels;
using WebArg.Web.Features.Persons.Managers.Interfaces;
using WebArg.Web.Features.Studios.DtoModels;

namespace WebArg.Web.Features.Persons.Managers;

/// <summary>
/// Менеджер обработки <see cref="Person"/>
/// </summary>
public sealed class PersonManager : IPersonManager
{
    private readonly IMapper _mapper;
    private readonly IPersonService _personService;
    private readonly IRepository<Person> _personRepository;

    private readonly DataContext _dataContext;

    public PersonManager(
        IMapper mapper,
        IPersonService personService,
        IRepository<Person> personRepository,
        DataContext dataContext)
    {
        _mapper = mapper;
        _personService = personService;
        _personRepository = personRepository;
        _dataContext = dataContext;
    }

    public async Task CreatePersonAsync(EditPersonDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Person>(source);

        _personRepository.Create(_dataContext, model);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdatePersonAsync(EditPersonDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Person>(source);

        await _personRepository.UpdateAsync(_dataContext, model, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<PersonDto> DeletePersonAsync(Guid isnPerson, CancellationToken cancellationToken)
    {
        var model = await _personRepository.DeleteAsync(_dataContext, isnPerson, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);

        return _mapper.Map<PersonDto>(model);
    }

    public async Task<EditPersonDto> GetPersonAsync(Guid isnPerson, CancellationToken cancellationToken)
    {
        var model = await _personRepository.GetByIdAsync(_dataContext, isnPerson, cancellationToken);

        return _mapper.Map<EditPersonDto>(model);
    }

    public async Task<PersonDto[]> GetListPersonAsync(Guid? isnStudio)
    {
        var persons = _personService
            .GetPersonQueryable(_dataContext, isnStudio)
            .Select(person => new PersonDto
            {
                IsnNode = person.IsnNode,
                IsnStudio = person.IsnStudio,
                Name = person.Name,
                LastVisit = person.LastVisit
            })
            .ToArray();

        return persons;
    }

    public async Task<InfoPersonDto> GetInfoPersonAsync(Guid isnPerson, CancellationToken cancellationToken)
    {
        var person = await _personService.GetInfoPersonAsync(_dataContext, isnPerson, cancellationToken);

        return new InfoPersonDto
        {
            IsnNode = person.IsnNode,
            IsnStudio = person.IsnStudio,
            Name = person.Name,
            LastVisit = person.LastVisit,
            Studio = new StudioDto
            {
                IsnNode = person.Studio.IsnNode,
                Name = person.Studio.Name,
                Location = person.Studio.Location
            },
            Masters = person.PersonMasters
                .Select(personMaster => new MasterDto
                {
                    IsnNode = personMaster.Master.IsnNode,
                    Name = personMaster.Master.Name,
                    Qualification = personMaster.Master.Qualification
                })
                .ToArray()
        };
    }
}
