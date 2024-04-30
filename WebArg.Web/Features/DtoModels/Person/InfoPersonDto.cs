using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.DtoModels.Person;

/// <summary>
/// Полные данные о клиенте
/// </summary>
public sealed record InfoPersonDto
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

    /// <summary>
    /// Студия закрепленная за клиентом
    /// </summary>
    public StudioDto Studio { get; init; }

    /// <summary>
    /// Список мастеров
    /// </summary>
    public MasterDto[] Masters { get; init; }
}
