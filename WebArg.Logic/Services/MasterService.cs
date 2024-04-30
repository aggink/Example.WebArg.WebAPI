using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services;

/// <summary>
/// Сервис для <see cref="Master"/>
/// </summary>
public sealed class MasterService : IMasterService
{
    public async Task SetBindWithPersonAsync(DataContext dataContext, Guid isnMaster, Guid isnPerson, CancellationToken cancellationToken)
    {
        var person = await dataContext.Persons.FirstOrDefaultAsync(x => x.IsnNode == isnPerson, cancellationToken)
            ?? throw new LogicException($"Гостя с таким идентификатором {isnPerson} не существует");

        var master = await dataContext.Masters.FirstOrDefaultAsync(x => x.IsnNode == isnMaster, cancellationToken)
            ?? throw new LogicException($"Мастера с идентификатором {isnMaster} не существует");

        var trainerCustomer = new MasterPerson
        {
            IsnPerson = person.IsnNode,
            IsnMaster = master.IsnNode
        };

        dataContext.MastersPersons.Add(trainerCustomer);
    }

    public async Task DeleteBindWithPersonAsync(DataContext dataContext, Guid isnMaster, Guid isnPerson, CancellationToken cancellationToken)
    {
        var trainerCustomer = await dataContext.MastersPersons
                .FirstOrDefaultAsync(x => x.IsnMaster == isnMaster && x.IsnPerson == isnPerson, cancellationToken)
                    ?? throw new LogicException($"Связи мастера {isnMaster} c клиентом {isnPerson} не существует");

        dataContext.MastersPersons.Remove(trainerCustomer);
    }

    public IQueryable<Master> GetMasterQueryable(DataContext dataContext)
    {
        var trainerQuery = dataContext.Masters
            .AsNoTracking();

        return trainerQuery;
    }

    public async Task<Master> GetInfoMasterAsync(DataContext dataContext, Guid isnMaster, CancellationToken cancellationToken)
    {
        var master = await dataContext.Masters
            .AsNoTracking()
            .Include(x => x.MasterStudios)
                .ThenInclude(x => x.Studio)
            .Include(x => x.MasterPersons)
                .ThenInclude(x => x.Person)
            .FirstOrDefaultAsync(x => x.IsnNode == isnMaster, cancellationToken)
                ?? throw new LogicException($"Мастера с идентификатором {isnMaster} не существует");

        return master;
    }
}
