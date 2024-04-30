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

namespace WebArg.Web.Features.Managers;

public sealed class MasterManager : IMasterManager
{
    private readonly IMapper _mapper;
    private readonly IMasterService _masterService;
    private readonly IRepository<Master> _masterRepository;

    private readonly DataContext _dataContext;

    public MasterManager(
        IMapper mapper,
        IMasterService masterService,
        IRepository<Master> mastersRepository,
        DataContext dataContext)
    {
        _mapper = mapper;
        _masterService = masterService;
        _masterRepository = mastersRepository;
        _dataContext = dataContext;
    }

    public async Task CreateMasterAsync(EditMasterDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Master>(source);

        _masterRepository.Create(_dataContext, model);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateMasterAsync(EditMasterDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Master>(source);

        _masterRepository.Update(_dataContext, model);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteMasterAsync(Guid isnMaster, CancellationToken cancellationToken)
    {
        _masterRepository.Delete(_dataContext, isnMaster);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<EditMasterDto> GetMasterAsync(Guid isnMaster)
    {
        var model = _masterRepository.GetById(_dataContext, isnMaster);

        return _mapper.Map<EditMasterDto>(model);
    }

    public async Task SetBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        _masterService.SetBindWithPerson(_dataContext, model.IsnMaster, model.IsnPerson);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        _masterService.DeleteBindWithPerson(_dataContext, model.IsnMaster, model.IsnPerson);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<MasterDto[]> GetListMasterAsync()
    {

        var masters = _masterService
            .GetMasterQueryable(_dataContext)
            .Select(master => new MasterDto
            {
                IsnNode = master.IsnNode,
                Name = master.Name,
                Qualification = master.Qualification,
            })
            .ToArray();

        return masters;
    }

    public async Task<InfoMasterDto> GetInfoMasterAsync(Guid isnMaster)
    {
        var model = _masterService.GetInfoMaster(_dataContext, isnMaster);


        return new InfoMasterDto
        {
            IsnNode = model.IsnNode,
            Name = model.Name,
            Qualification = model.Qualification,
            Studios = model.MasterStudios
                .Select(masterStudio => new StudioDto
                {
                    IsnNode = masterStudio.Studio.IsnNode,
                    Name = masterStudio.Studio.Name,
                    Location = masterStudio.Studio.Location
                })
                .ToArray(),
            Persons = model.MasterPersons
                .Select(masterPerson => new PersonDto
                {
                    IsnNode = masterPerson.Person.IsnNode,
                    IsnStudio = masterPerson.Person.IsnStudio,
                    Name = masterPerson.Person.Name,
                    LastVisit = masterPerson.Person.LastVisit,
                })
                .ToArray()
        };
    }
}
