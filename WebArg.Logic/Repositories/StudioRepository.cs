using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories
{
    public sealed class StudioRepository : IRepository<Studio>
    {
        public Studio Create(DataContext dataContext, Studio model)
        {
            model.IsnNode = Guid.NewGuid();
            dataContext.Studios.Add(model);

            return model;
        }

        public Studio Delete(DataContext dataContext, Guid isnNode)
        {
            var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == isnNode)
                ?? throw new Exception($"Студии с таким идентификатором {isnNode} не существует");

            dataContext.Studios.Remove(studio);

            return studio;
        }

        public Studio GetById(DataContext dataContext, Guid isnNode)
        {
            var studio = dataContext.Studios
                .AsNoTracking()
                .FirstOrDefault(x => x.IsnNode == isnNode)
                    ?? throw new Exception($"Студии с таким идентификатором {isnNode} не существует");

            return studio;
        }

        public Studio Update(DataContext dataContext, Studio model)
        {
            var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == model.IsnNode)
                ?? throw new Exception($"Студии с таким идентификатором {model.IsnNode} не существует");

            studio.Name = model.Name;
            studio.Location = model.Location;

            return studio;
        }
    }
}
