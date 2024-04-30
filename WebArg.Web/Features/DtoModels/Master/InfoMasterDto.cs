using WebArg.Web.Features.DtoModels.Person;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.DtoModels.Master;

/// <summary>
/// Полные данные о мастере
/// </summary>
public sealed record InfoMasterDto
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

    /// <summary>
    /// Список прикрепленных студий
    /// </summary>
    public StudioDto[] Studios { get; init; }

    /// <summary>
    /// Список прикрепленных клиентов
    /// </summary>
    public PersonDto[] Persons { get; init; }
}
