using AutoMapper;
using Marketplace.Web.Common.PagedList.Helpers;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;
using WebArg.Web.Common.PagedList.Helpers;
using WebArg.Web.Features.Masters.DtoModels;
using WebArg.Web.Features.Masters.Managers.Interfaces;
using WebArg.Web.Features.Masters.Queries;
using WebArg.Web.Features.Persons.DtoModels;
using WebArg.Web.Features.Studios.DtoModels;
using X.PagedList;

namespace WebArg.Web.Features.Masters.Managers;

/// <summary>
/// Менеджер обработки <see cref="Master"/>
/// </summary>
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

        await _masterRepository.UpdateAsync(_dataContext, model, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteMasterAsync(Guid isnMaster, CancellationToken cancellationToken)
    {
        await _masterRepository.DeleteAsync(_dataContext, isnMaster, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<EditMasterDto> GetMasterAsync(Guid isnMaster, CancellationToken cancellationToken)
    {
        var model = await _masterRepository.GetByIdAsync(_dataContext, isnMaster, cancellationToken);

        return _mapper.Map<EditMasterDto>(model);
    }

    public async Task SetBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterService.SetBindWithPersonAsync(_dataContext, model.IsnMaster, model.IsnPerson, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteBindWithPersonAsync(SetBindWithPersonDto model, CancellationToken cancellationToken)
    {
        await _masterService.DeleteBindWithPersonAsync(_dataContext, model.IsnMaster, model.IsnPerson, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IPagedList<MasterDto>> GetListMasterAsync(GetListMasterQuery query)
    {
        var actionState = ActionStateHelper.GetActionState(query);

        var masters = _masterService
            .GetMasterQueryable(_dataContext)
            .Select(master => new MasterDto
            {
                IsnNode = master.IsnNode,
                Name = master.Name,
                Qualification = master.Qualification,
            });

        return PagedListHelper.GetPagedList(masters, actionState);
    }

    public async Task<InfoMasterDto> GetInfoMasterAsync(Guid isnMaster, CancellationToken cancellationToken)
    {
        var model = await _masterService.GetInfoMasterAsync(_dataContext, isnMaster, cancellationToken);

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
