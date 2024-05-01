using WebArg.Web.Common.PagedList.Models;

namespace WebArg.Web.Features.Persons.Queries;

/// <summary>
/// Получить список клиентов
/// </summary>
public class GetListPersonQuery : ActionStateQuery
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    public Guid? IsnStudio { get; set; }
}
