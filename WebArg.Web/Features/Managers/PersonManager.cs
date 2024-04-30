using AutoMapper;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;
using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Person;
using WebArg.Web.Features.DtoModels.Studio;
using WebArg.Web.Features.Interfaces;

namespace WebArg.Web.Features.Managers
{
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

        public async Task CreateРersonAsync(EditPersonDto source, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Person>(source);

            _personRepository.Create(_dataContext, model);

            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateРersonAsync(EditPersonDto source, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Person>(source);

            _personRepository.Update(_dataContext, model);

            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<PersonDto> DeleteРersonAsync(Guid isnPerson, CancellationToken cancellationToken)
        {
            var model = _personRepository.Delete(_dataContext, isnPerson);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<PersonDto>(model);
        }

        public async Task<EditPersonDto> GetРersonAsync(Guid isnPerson)
        {
            var model = _personRepository.GetById(_dataContext, isnPerson);

            return _mapper.Map<EditPersonDto>(model);
        }

        public async Task<PersonDto[]> GetListРersonAsync(Guid? isnStudio)
        {

            var persons = _personService
                .GetРersonQueryable(_dataContext, isnStudio)
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

        public async Task<InfoPersonDto> GetInfoPersonAsync(Guid isnPerson)
        {
            var person = _personService.GetInfoPerson(_dataContext, isnPerson);

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
}
