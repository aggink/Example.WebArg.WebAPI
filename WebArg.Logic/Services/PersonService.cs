using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services
{
    public sealed class PersonService : IPersonService
    {
        public IQueryable<Person> GetРersonQueryable(DataContext dataContext, Guid? isnStudio)
        {
            IQueryable<Person> customerQuery = dataContext.Persons
                .AsNoTracking();

            if (isnStudio.HasValue)
                customerQuery = customerQuery.Where(x => x.IsnStudio == isnStudio);

            return customerQuery;
        }

        public Person GetInfoРerson(DataContext dataContext, Guid isnPerson)
        {
            var person = dataContext.Persons
                .AsNoTracking()
                .Include(x => x.Studio)
                .Include(x => x.PersonMasters)
                    .ThenInclude(x => x.Master)
                .FirstOrDefault(x => x.IsnNode == isnPerson)
                    ?? throw new Exception($"Гостя с таким идентификатором {isnPerson} не существует");

            return person;
        }
    }
}
