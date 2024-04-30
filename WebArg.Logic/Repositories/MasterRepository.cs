using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories;

/// <summary>
/// CRUD методы для <see cref="Master"/>
/// </summary>
public sealed class MasterRepository : IRepository<Master>
{
    public Master Create(DataContext dataContext, Master model)
    {
        model.IsnNode = Guid.NewGuid();
        dataContext.Masters.Add(model);

        return model;
    }

    public async Task<Master> DeleteAsync(DataContext dataContext, Guid isnNode)
    {
        var master = await dataContext.Masters.FirstOrDefaultAsync(x => x.IsnNode == isnNode)
            ?? throw new LogicException($"Мастера с таким идентификатором {isnNode} не существует");

        dataContext.Masters.Remove(master);

        return master;
    }

    public async Task<Master> GetByIdAsync(DataContext dataContext, Guid isnNode)
    {
        var master = await dataContext.Masters
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IsnNode == isnNode)
                ?? throw new LogicException($"Мастера с таким идентификатором {isnNode} не существует");

        return master;
    }

    public async Task<Master> UpdateAsync(DataContext dataContext, Master model)
    {
        var master = await dataContext.Masters.FirstOrDefaultAsync(x => x.IsnNode == model.IsnNode)
            ?? throw new LogicException($"Мастера с таким идентификатором {model.IsnNode} не существует");

        master.Name = model.Name;
        master.Qualification = model.Qualification;

        return master;
    }
}
