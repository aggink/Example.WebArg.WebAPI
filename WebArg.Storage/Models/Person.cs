using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models;

/// <summary>
/// Клиент
/// </summary>
public class Person
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IsnNode { get; set; }

    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [ForeignKey(nameof(Studio))]
    public Guid IsnStudio { get; set; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required, MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// Последний визит
    /// </summary>
    [Required, MaxLength(100)]
    public DateTime LastVisit { get; set; }

    /// <summary>
    /// Студия
    /// </summary>
    public virtual Studio Studio { get; set; }

    /// <summary>
    /// Связь клиента с мастерами
    /// </summary>
    [InverseProperty(nameof(MasterPerson.Person))]
    public virtual ICollection<MasterPerson> PersonMasters { get; set; }
}
