namespace WebArg.Web.Features.DtoModels.Person;

/// <summary>
/// Клиент
/// </summary>
public sealed record PersonDto
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Идентификатор студии
    /// </summary>
    public Guid IsnStudio { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Дата последнего визита
    /// </summary>
    public DateTime LastVisit { get; init; }
}
