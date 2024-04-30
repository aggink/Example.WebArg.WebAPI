using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Persons.Queries;

/// <summary>
/// Получить клиента для редактирования
/// </summary>
public sealed record GetEditPersonQuery
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnPerson { get; init; }
}
