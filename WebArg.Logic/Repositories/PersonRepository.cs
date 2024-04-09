using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Interfaces.Repositories;
using WebArg.Storage.Database;
using WebArg.Storage.Models;

namespace WebArg.Logic.Repositories
{
    public sealed class PersonRepository : IRepository<Person>
    {
        public Person Create(DataContext dataContext, Person model)
        {
            var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == model.IsnStudio)
                ?? throw new Exception($"Студии с таким идентификатором {model.IsnStudio} не существует");

            model.IsnNode = Guid.NewGuid();
            dataContext.Persons.Add(model);

            return model;
        }

        public Person Delete(DataContext dataContext, Guid isnNode)
        {
            var person = dataContext.Persons.FirstOrDefault(x => x.IsnNode == isnNode)
                ?? throw new Exception($"Гостя с таким идентификатором {isnNode} не существует");

            dataContext.Persons.Remove(person);

            return person;
        }

        public Person GetById(DataContext dataContext, Guid isnNode)
        {
            var person = dataContext.Persons
                .AsNoTracking()
                .FirstOrDefault(x => x.IsnNode == isnNode)
                    ?? throw new Exception($"Гостя с таким идентификатором {isnNode} не существует");

            return person;
        }

        public Person Update(DataContext dataContext, Person model)
        {
            var person = dataContext.Persons.FirstOrDefault(x => x.IsnNode == model.IsnNode)
                ?? throw new Exception($"Гостя с таким идентификатором {model.IsnNode} не существует");

            var studio = dataContext.Studios.FirstOrDefault(x => x.IsnNode == model.IsnStudio)
                ?? throw new Exception($"Студии с таким идентификатором {model.IsnStudio} не существует");

            person.IsnStudio = model.IsnStudio;
            person.Name = model.Name;
            person.LastVisit = model.LastVisit;
            person.Studio = studio;

            return person;
        }
    }
}
