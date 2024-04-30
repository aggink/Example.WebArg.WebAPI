using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Studio;

/// <summary>
/// Модель студии для редактирования
/// </summary>
public sealed record EditStudioDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Наименование
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
    public string Name { get; init; }

    /// <summary>
    /// Местоположение
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
    public string Location { get; init; }
}
