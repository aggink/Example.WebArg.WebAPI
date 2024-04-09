using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories
{
    public sealed class MasterRepository : IRepository<Master>
    {
        public Master Create(DataContext dataContext, Master model)
        {
            model.IsnNode = Guid.NewGuid();
            dataContext.Masters.Add(model);

            return model;
        }

        public Master Delete(DataContext dataContext, Guid isnNode)
        {
            var master = dataContext.Masters.FirstOrDefault(x => x.IsnNode == isnNode)
                ?? throw new Exception($"Мастера с таким идентификатором {isnNode} не существует");

            dataContext.Masters.Remove(master);

            return master;
        }

        public Master GetById(DataContext dataContext, Guid isnNode)
        {
            var master = dataContext.Masters
                .AsNoTracking()
                .FirstOrDefault(x => x.IsnNode == isnNode)
                    ?? throw new Exception($"Мастера с таким идентификатором {isnNode} не существует");

            return master;
        }

        public Master Update(DataContext dataContext, Master model)
        {
            var master = dataContext.Masters.FirstOrDefault(x => x.IsnNode == model.IsnNode)
                ?? throw new Exception($"Мастера с таким идентификатором {model.IsnNode} не существует");


            master.Name = model.Name;
            master.Qualification = model.Qualification;

            return master;
        }
    }
}
