using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Master;

/// <summary>
/// Модель для редактирования мастера
/// </summary>
public sealed record EditMasterDto
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
    public string Name { get; init; }

    /// <summary>
    /// Специализация
    /// </summary>
    [Required(ErrorMessageResourceName = "Required")]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
    public string Qualification { get; init; }
}
