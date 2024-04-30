using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Studios.Queries;

/// <summary>
/// Получить полную информацию о студии
/// </summary>
public sealed record GetInfoStudioQuery
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnStudio { get; init; }
}
