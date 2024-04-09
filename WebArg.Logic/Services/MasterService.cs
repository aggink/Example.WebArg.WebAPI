using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services
{
    public sealed class MasterService : IMasterService
    {
        public void SetBindWithPerson(DataContext dataContext, Guid isnMaster, Guid isnPerson)
        {
            var person = dataContext.Persons.FirstOrDefault(x => x.IsnNode == isnPerson)
                ?? throw new Exception($"Гостя с таким идентификатором {isnPerson} не существует");

            var master = dataContext.Masters.FirstOrDefault(x => x.IsnNode == isnMaster)
                ?? throw new Exception($"Мастера с идентификатором {isnMaster} не существует");

            var trainerCustomer = new MasterPerson
            {
                IsnPerson = person.IsnNode,
                IsnMaster = master.IsnNode
            };

            dataContext.MastersPersons.Add(trainerCustomer);
        }

        public void DeleteBindWithPerson(DataContext dataContext, Guid isnMaster, Guid isnPerson)
        {
            var trainerCustomer = dataContext.MastersPersons.FirstOrDefault(x => x.IsnMaster == isnMaster && x.IsnPerson == isnPerson)
                ?? throw new Exception($"Связи мастера {isnMaster} c клиентом {isnPerson} не существует");

            dataContext.MastersPersons.Remove(trainerCustomer);
        }

        public IQueryable<Master> GetMasterQueryable(DataContext dataContext)
        {
            var trainerQuery = dataContext.Masters
                .AsNoTracking();

            return trainerQuery;
        }

        public Master GetInfoMaster(DataContext dataContext, Guid isnMaster)
        {
            var master = dataContext.Masters
                .AsNoTracking()
                .Include(x => x.MasterStudios)
                    .ThenInclude(x => x.Studio)
                .Include(x => x.MasterPersons)
                    .ThenInclude(x => x.Person)
                .FirstOrDefault(x => x.IsnNode == isnMaster)
                    ?? throw new Exception($"Мастера с идентификатором {isnMaster} не существует");

            return master;
        }
    }
}
