using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Person;

/// <summary>
/// Модель клиента для редактирования
/// </summary>
public sealed record EditPersonDto
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnStudio { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
    public string Name { get; init; }

    /// <summary>
    /// Дата последнего визита
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public DateTime LastVisit { get; init; }
}
