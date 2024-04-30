using WebArg.Web.Features.Persons.DtoModels;
using WebArg.Web.Features.Studios.DtoModels;

namespace WebArg.Web.Features.Masters.DtoModels;

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
