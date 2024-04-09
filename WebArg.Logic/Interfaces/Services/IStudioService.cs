using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Interfaces.Services
{
    public interface IStudioService
    {
        void SetBindWithMaster(DataContext dataContext, Guid isnStudio, Guid isnMaster);

        void DeleteBindWithMaster(DataContext dataContext, Guid isnStudio, Guid isnMaster);

        IQueryable<Studio> GetStudioQueryable(DataContext dataContext);

        Studio GetInfoStudio(DataContext dataContext, Guid isnStudio);
    }
}
