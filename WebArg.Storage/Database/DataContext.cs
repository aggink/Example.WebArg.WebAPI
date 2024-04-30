using Microsoft.EntityFrameworkCore;
using WebArg.Storage.Models;

namespace WebArg.Storage.Database;

/// <summary>
/// Контекст базы данных
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    /// <summary>
    /// Студии
    /// </summary>
    public virtual DbSet<Studio> Studios { get; set; }

    /// <summary>
    /// Мастера
    /// </summary>
    public virtual DbSet<Master> Masters { get; set; }

    /// <summary>
    /// Клиенты
    /// </summary>
    public virtual DbSet<Person> Persons { get; set; }

    /// <summary>
    /// Связь студии с мастерами
    /// </summary>
    public virtual DbSet<StudioMaster> StudiosMasters { get; set; }

    /// <summary>
    /// Связь мастеров с клиентами
    /// </summary>
    public virtual DbSet<MasterPerson> MastersPersons { get; set; }
}
