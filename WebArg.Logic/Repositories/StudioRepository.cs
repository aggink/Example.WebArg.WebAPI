using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories;

/// <summary>
/// CRUD методы для <see cref="Studio"/>
/// </summary>
public sealed class StudioRepository : IRepository<Studio>
{
    public Studio Create(DataContext dataContext, Studio model)
    {
        model.IsnNode = Guid.NewGuid();
        dataContext.Studios.Add(model);

        return model;
    }

    public async Task<Studio> DeleteAsync(DataContext dataContext, Guid isnNode, CancellationToken cancellationToken)
    {
        var studio = await dataContext.Studios.FirstOrDefaultAsync(x => x.IsnNode == isnNode, cancellationToken)
            ?? throw new LogicException($"Студии с таким идентификатором {isnNode} не существует");

        dataContext.Studios.Remove(studio);

        return studio;
    }

    public async Task<Studio> GetByIdAsync(DataContext dataContext, Guid isnNode, CancellationToken cancellationToken)
    {
        var studio = await dataContext.Studios
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IsnNode == isnNode, cancellationToken)
                ?? throw new LogicException($"Студии с таким идентификатором {isnNode} не существует");

        return studio;
    }

    public async Task<Studio> UpdateAsync(DataContext dataContext, Studio model, CancellationToken cancellationToken)
    {
        var studio = await dataContext.Studios.FirstOrDefaultAsync(x => x.IsnNode == model.IsnNode, cancellationToken)
            ?? throw new LogicException($"Студии с таким идентификатором {model.IsnNode} не существует");

        studio.Name = model.Name;
        studio.Location = model.Location;

        return studio;
    }
}
