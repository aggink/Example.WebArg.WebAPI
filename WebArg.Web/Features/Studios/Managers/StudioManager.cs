﻿using AutoMapper;
using Marketplace.Web.Common.PagedList.Helpers;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;
using WebArg.Web.Common.PagedList.Helpers;
using WebArg.Web.Features.Masters.DtoModels;
using WebArg.Web.Features.Persons.DtoModels;
using WebArg.Web.Features.Studios.DtoModels;
using WebArg.Web.Features.Studios.Managers.Interfaces;
using WebArg.Web.Features.Studios.Queries;
using X.PagedList;

namespace WebArg.Web.Features.Studios.Managers;

/// <summary>
/// Менеджер обработки <see cref="Studio"/>
/// </summary>
public sealed class StudioManager : IStudioManager
{
    private readonly IMapper _mapper;
    private readonly IStudioService _studioService;
    private readonly IRepository<Studio> _studioRepository;

    private readonly DataContext _dataContext;

    public StudioManager(
        IMapper mapper,
        IStudioService studioService,
        IRepository<Studio> centerRepository,
        DataContext dataContext)
    {
        _mapper = mapper;
        _studioService = studioService;
        _studioRepository = centerRepository;
        _dataContext = dataContext;
    }

    public async Task CreateStudioAsync(EditStudioDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Studio>(source);

        _studioRepository.Create(_dataContext, model);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateStudioAsync(EditStudioDto source, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Studio>(source);

        await _studioRepository.UpdateAsync(_dataContext, model, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteStudioAsync(Guid isnStudio, CancellationToken cancellationToken)
    {
        await _studioRepository.DeleteAsync(_dataContext, isnStudio, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<EditStudioDto> GetStudioAsync(Guid isnStudio, CancellationToken cancellationToken)
    {
        var model = await _studioRepository.GetByIdAsync(_dataContext, isnStudio, cancellationToken);

        return _mapper.Map<EditStudioDto>(model);
    }

    public async Task SetBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioService.SetBindWithMasterAsync(_dataContext, model.IsnStudio, model.IsnMaster, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteBindWithMasterAsync(SetBindWithMasterDto model, CancellationToken cancellationToken)
    {
        await _studioService.SetBindWithMasterAsync(_dataContext, model.IsnStudio, model.IsnMaster, cancellationToken);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<InfoStudioDto> GetInfoStudioAsync(Guid isnStudio, CancellationToken cancellationToken)
    {
        // todo: необходимо выделить в PagedList, чтоб не тащить все из БД
        var studio = await _studioService.GetInfoStudioAsync(_dataContext, isnStudio, cancellationToken);

        return new InfoStudioDto
        {
            IsnNode = studio.IsnNode,
            Name = studio.Name,
            Location = studio.Location,
            Persons = studio.Persons
                .Select(person => new PersonDto
                {
                    IsnNode = person.IsnNode,
                    IsnStudio = person.IsnStudio,
                    Name = person.Name,
                    LastVisit = person.LastVisit
                })
                .ToArray(),
            Masters = studio.StudioMasters
                .Select(studioMaster => new MasterDto
                {
                    IsnNode = studioMaster.Master.IsnNode,
                    Name = studioMaster.Master.Name,
                    Qualification = studioMaster.Master.Qualification
                })
                .ToArray()
        };
    }

    public async Task<IPagedList<StudioDto>> GetListStudioAsync(GetListStudiosQuery query)
    {
        var actionState = ActionStateHelper.GetActionState(query);

        var studios = _studioService
            .GetStudioQueryable(_dataContext)
            .Select(x => new StudioDto
            {
                IsnNode = x.IsnNode,
                Name = x.Name,
                Location = x.Location,
            });

        return PagedListHelper.GetPagedList(studios, actionState);
    }
}
