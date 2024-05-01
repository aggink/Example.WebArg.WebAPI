using WebArg.Storage.Models;

namespace WebArg.Logic.DtoModels;

/// <summary>
/// Фильтры для <see cref="Person"/>
/// </summary>
public sealed class PersonFilter
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    public Guid? IsnStudio { get; set; }
}
