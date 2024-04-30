using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Persons.Queries;

/// <summary>
/// Получить полную информацию о клиенте
/// </summary>
public sealed record GetInfoPersonQuery
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnPerson { get; init; }
}
