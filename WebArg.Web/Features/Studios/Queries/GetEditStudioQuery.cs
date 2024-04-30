using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Studios.Queries;

/// <summary>
/// Получить студию для редактирования
/// </summary>
public sealed record GetEditStudioQuery
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnStudio { get; init; }
}
