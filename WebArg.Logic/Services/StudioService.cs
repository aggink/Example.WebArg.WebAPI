using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Services;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Services
{
    public sealed class StudioService : IStudioService
    {
        public void SetBindWithMaster(DataContext dataContext, Guid isnStudio, Guid isnMaster)
        {
            var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == isnStudio)
                ?? throw new Exception($"Студии с таким идентификатором {isnStudio} не существует");

            var master = dataContext.Masters.FirstOrDefault(x => x.IsnNode == isnMaster)
                ?? throw new Exception($"Мастера с таким идентификатором {isnMaster} не существует");

            var studioMaster = new StudioMaster
            {
                IsnStudio = isnStudio,
                IsnMaster = isnMaster
            };

            dataContext.StudiosMasters.Add(studioMaster);
        }

        public void DeleteBindWithMaster(DataContext dataContext, Guid isnStudio, Guid isnMaster)
        {
            var studioMaster = dataContext.StudiosMasters.FirstOrDefault(x => x.IsnStudio == isnStudio && x.IsnMaster == isnMaster)
                ?? throw new Exception($"Связи студии {isnStudio} с мастером не существует {isnMaster}");

            dataContext.StudiosMasters.Remove(studioMaster);
        }

        public IQueryable<Studio> GetStudioQueryable(DataContext dataContext)
        {
            var centerQuery = dataContext.Studios
                .AsNoTracking();

            return centerQuery;
        }

        public Studio GetInfoStudio(DataContext dataContext, Guid isnStudio)
        {
            var studio = dataContext.Studios
                .AsNoTracking()
                .Include(x => x.Persons)
                .Include(x => x.StudioMasters)
                    .ThenInclude(x => x.Master)
                .FirstOrDefault(x => x.IsnNode == isnStudio)
                    ?? throw new Exception($"Студии с таким идентификатором {isnStudio} не существует");

            return studio;
        }
    }
}
