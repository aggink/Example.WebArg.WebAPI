namespace WebArg.Web.Features.DtoModels.Master;

/// <summary>
/// Мастер
/// </summary>
public sealed record MasterDto
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    public Guid IsnNode { get; init; }

    /// <summary>
    /// ФИО
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Квалификация
    /// </summary>
    public string Qualification { get; init; }
}
