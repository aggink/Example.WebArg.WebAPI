using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Studios.DtoModels;

/// <summary>
/// Модель студии для редактирования
/// </summary>
public sealed record EditStudioDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Наименование
    /// </summary>
    [Required]
    public string Name { get; init; }

    /// <summary>
    /// Местоположение
    /// </summary>
    [Required]
    public string Location { get; init; }
}
