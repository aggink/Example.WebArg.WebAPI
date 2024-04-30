using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories;

/// <summary>
/// CRUD методы для <see cref="Person"/>
/// </summary>
public sealed class PersonRepository : IRepository<Person>
{
    public Person Create(DataContext dataContext, Person model)
    {
        var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == model.IsnStudio)
            ?? throw new LogicException($"Студии с таким идентификатором {model.IsnStudio} не существует");

        model.IsnNode = Guid.NewGuid();
        dataContext.Persons.Add(model);

        return model;
    }

    public async Task<Person> DeleteAsync(DataContext dataContext, Guid isnNode, CancellationToken cancellationToken)
    {
        var person = await dataContext.Persons.FirstOrDefaultAsync(x => x.IsnNode == isnNode, cancellationToken)
            ?? throw new LogicException($"Гостя с таким идентификатором {isnNode} не существует");

        dataContext.Persons.Remove(person);

        return person;
    }

    public async Task<Person> GetByIdAsync(DataContext dataContext, Guid isnNode, CancellationToken cancellationToken)
    {
        var person = await dataContext.Persons
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IsnNode == isnNode, cancellationToken)
                ?? throw new LogicException($"Гостя с таким идентификатором {isnNode} не существует");

        return person;
    }

    public async Task<Person> UpdateAsync(DataContext dataContext, Person model, CancellationToken cancellationToken)
    {
        var person = await dataContext.Persons.FirstOrDefaultAsync(x => x.IsnNode == model.IsnNode, cancellationToken)
            ?? throw new LogicException($"Гостя с таким идентификатором {model.IsnNode} не существует");

        var studio = await dataContext.Studios.FirstOrDefaultAsync(x => x.IsnNode == model.IsnStudio, cancellationToken)
            ?? throw new LogicException($"Студии с таким идентификатором {model.IsnStudio} не существует");

        person.IsnStudio = model.IsnStudio;
        person.Name = model.Name;
        person.LastVisit = model.LastVisit;
        person.Studio = studio;

        return person;
    }
}
