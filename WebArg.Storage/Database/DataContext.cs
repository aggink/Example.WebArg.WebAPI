using Microsoft.EntityFrameworkCore;
using WebArg.Storage.Models;

namespace WebArg.Storage.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Studio> Studios { get; set; }

        public virtual DbSet<Master> Masters { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<StudioMaster> StudiosMasters { get; set; }

        public virtual DbSet<MasterPerson> MastersPersons { get; set; }
    }
}
