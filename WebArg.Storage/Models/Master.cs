using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models;

/// <summary>
/// Мастер
/// </summary>
public class Master
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IsnNode { get; set; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required, MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// Квалификация
    /// </summary>
    [Required, MaxLength(100)]
    public string Qualification { get; set; }

    /// <summary>
    /// Связь мастера со студиями
    /// </summary>
    [InverseProperty(nameof(StudioMaster.Master))]
    public virtual ICollection<StudioMaster> MasterStudios { get; set; }

    /// <summary>
    /// Связь мастера с клиентами
    /// </summary>
    [InverseProperty(nameof(MasterPerson.Master))]
    public virtual ICollection<MasterPerson> MasterPersons { get; set; }
}
