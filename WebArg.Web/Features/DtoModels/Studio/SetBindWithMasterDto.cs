using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Studio;

/// <summary>
/// Связь студии с мастером
/// </summary>
public sealed record SetBindWithMasterDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnStudio { get; init; }

    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnMaster { get; init; }
}
