using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services
{
    public interface IMasterService
    {
        void SetBindWithPerson(DataContext dataContext, Guid isnMaster, Guid isnPerson);

        void DeleteBindWithPerson(DataContext dataContext, Guid isnMaster, Guid isnPerson);

        IQueryable<Master> GetMasterQueryable(DataContext dataContext);

        Master GetInfoMaster(DataContext dataContext, Guid isnMaster);
    }
}
