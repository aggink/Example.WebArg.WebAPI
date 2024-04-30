using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Studios.DtoModels;

/// <summary>
/// Связь студии с мастером
/// </summary>
public sealed record SetBindWithMasterDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    public Guid IsnStudio { get; init; }

    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required]
    public Guid IsnMaster { get; init; }
}
