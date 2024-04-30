using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models;

/// <summary>
/// Связь мастеров с клиентами
/// </summary>
[Index(nameof(IsnMaster), nameof(IsnPerson))]
[PrimaryKey(nameof(IsnMaster), nameof(IsnPerson))]
public class MasterPerson
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [ForeignKey(nameof(Master)), Required]
    public Guid IsnMaster { get; set; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [ForeignKey(nameof(Person)), Required]
    public Guid IsnPerson { get; set; }

    /// <summary>
    /// Мастер
    /// </summary>
    public virtual Master Master { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public virtual Person Person { get; set; }
}
