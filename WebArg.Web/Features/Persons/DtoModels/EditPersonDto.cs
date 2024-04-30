using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Persons.DtoModels;

/// <summary>
/// Модель клиента для редактирования
/// </summary>
public sealed record EditPersonDto
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    public Guid IsnStudio { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required]
    public string Name { get; init; }

    /// <summary>
    /// Дата последнего визита
    /// </summary>
    [Required]
    public DateTime LastVisit { get; init; }
}
