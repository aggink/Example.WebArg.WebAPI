using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Masters.DtoModels;

/// <summary>
/// Связь мастера с клиентом
/// </summary>
public sealed record SetBindWithPersonDto
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required]
    public Guid IsnMaster { get; init; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required]
    public Guid IsnPerson { get; init; }
}
