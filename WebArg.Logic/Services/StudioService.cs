using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services;

/// <summary>
/// Сервис для <see cref="Studio"/>
/// </summary>
public sealed class StudioService : IStudioService
{
    public async Task SetBindWithMasterAsync(DataContext dataContext, Guid isnStudio, Guid isnMaster)
    {
        var studio = await dataContext.Studios.FirstOrDefaultAsync(x => x.IsnNode == isnStudio)
            ?? throw new LogicException($"Студии с таким идентификатором {isnStudio} не существует");

        var master = await dataContext.Masters.FirstOrDefaultAsync(x => x.IsnNode == isnMaster)
            ?? throw new LogicException($"Мастера с таким идентификатором {isnMaster} не существует");

        var studioMaster = new StudioMaster
        {
            IsnStudio = isnStudio,
            IsnMaster = isnMaster
        };

        dataContext.StudiosMasters.Add(studioMaster);
    }

    public async Task DeleteBindWithMasterAsync(DataContext dataContext, Guid isnStudio, Guid isnMaster)
    {
        var studioMaster = await dataContext.StudiosMasters
            .FirstOrDefaultAsync(x => x.IsnStudio == isnStudio && x.IsnMaster == isnMaster)
                ?? throw new LogicException($"Связи студии {isnStudio} с мастером не существует {isnMaster}");

        dataContext.StudiosMasters.Remove(studioMaster);
    }

    public IQueryable<Studio> GetStudioQueryable(DataContext dataContext)
    {
        var centerQuery = dataContext.Studios
            .AsNoTracking();

        return centerQuery;
    }

    public async Task<Studio> GetInfoStudioAsync(DataContext dataContext, Guid isnStudio)
    {
        var studio = await dataContext.Studios
            .AsNoTracking()
            .Include(x => x.Persons)
            .Include(x => x.StudioMasters)
                .ThenInclude(x => x.Master)
            .FirstOrDefaultAsync(x => x.IsnNode == isnStudio)
                ?? throw new LogicException($"Студии с таким идентификатором {isnStudio} не существует");

        return studio;
    }
}
