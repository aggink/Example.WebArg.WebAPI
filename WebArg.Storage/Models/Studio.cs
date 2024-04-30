using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models;

/// <summary>
/// Студия
/// </summary>
public class Studio
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IsnNode { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    [Required, MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// Местоположение
    /// </summary>
    [Required, MaxLength(100)]
    public string Location { get; set; }

    /// <summary>
    /// Клиенты
    /// </summary>
    [InverseProperty(nameof(Person.Studio))]
    public virtual ICollection<Person> Persons { get; set; }

    /// <summary>
    /// Связь студии с мастерами
    /// </summary>
    [InverseProperty(nameof(StudioMaster.Studio))]
    public virtual ICollection<StudioMaster> StudioMasters { get; set; }
}
