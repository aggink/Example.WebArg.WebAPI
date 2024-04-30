using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Exceptions;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services;

/// <summary>
/// Сервис для <see cref="Person"/>
/// </summary>
public sealed class PersonService : IPersonService
{
    public IQueryable<Person> GetPersonQueryable(DataContext dataContext, Guid? isnStudio)
    {
        IQueryable<Person> customerQuery = dataContext.Persons
            .AsNoTracking();

        if (isnStudio.HasValue)
            customerQuery = customerQuery.Where(x => x.IsnStudio == isnStudio);

        return customerQuery;
    }

    public async Task<Person> GetInfoPersonAsync(DataContext dataContext, Guid isnPerson)
    {
        var person = await dataContext.Persons
            .AsNoTracking()
            .Include(x => x.Studio)
            .Include(x => x.PersonMasters)
                .ThenInclude(x => x.Master)
            .FirstOrDefaultAsync(x => x.IsnNode == isnPerson)
                ?? throw new LogicException($"Гостя с таким идентификатором {isnPerson} не существует");

        return person;
    }
}
