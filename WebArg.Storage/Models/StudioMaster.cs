using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models;

/// <summary>
/// Связь студии с мастерами
/// </summary>
[Index(nameof(IsnStudio), nameof(IsnMaster))]
[PrimaryKey(nameof(IsnStudio), nameof(IsnMaster))]
public class StudioMaster
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [ForeignKey(nameof(Studio)), Required]
    public Guid IsnStudio { get; set; }

    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [ForeignKey(nameof(Master)), Required]
    public Guid IsnMaster { get; set; }

    /// <summary>
    /// Студии
    /// </summary>
    public virtual Studio Studio { get; set; }

    /// <summary>
    /// Мастера
    /// </summary>
    public virtual Master Master { get; set; }
}
