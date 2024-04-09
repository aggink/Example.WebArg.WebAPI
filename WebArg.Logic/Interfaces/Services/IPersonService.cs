using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services
{
    public interface IPersonService
    {
        IQueryable<Person> GetРersonQueryable(DataContext dataContext, Guid? isnStudio);

        Person GetInfoРerson(DataContext dataContext, Guid isnPerson);
    }
}
