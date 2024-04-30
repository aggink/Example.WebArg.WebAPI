using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.DtoModels.Studio;

/// <summary>
/// Полные данные о студии
/// </summary>
public sealed record InfoStudioDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Местоположение
    /// </summary>
    public string Location { get; init; }

    /// <summary>
    /// Список мастеров
    /// </summary>
    public MasterDto[] Masters { get; init; }

    /// <summary>
    /// Список клиентов
    /// </summary>
    public PersonDto[] Persons { get; init; }
}
