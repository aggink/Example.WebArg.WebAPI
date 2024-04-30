using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Studios.Queries;

/// <summary>
/// Удалить студию
/// </summary>
public sealed record DeleteStudioQuery
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnStudio { get; init; }
}
