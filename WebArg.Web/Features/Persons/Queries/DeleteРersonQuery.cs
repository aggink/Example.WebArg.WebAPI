using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Persons.Queries;

/// <summary>
/// Удалить клиента
/// </summary>
public sealed record DeleteРersonQuery
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnPerson { get; init; }
}
