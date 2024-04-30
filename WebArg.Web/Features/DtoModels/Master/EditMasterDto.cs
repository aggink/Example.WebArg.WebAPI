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
    [Required]
    public Guid IsnNode { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Required]
    public string Name { get; init; }

    /// <summary>
    /// Специализация
    /// </summary>
    [Required]
    public string Qualification { get; init; }
}
