using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Masters.Queries;

/// <summary>
/// Удалить мастера
/// </summary>
public sealed record DeleteMasterQuery
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnMaster { get; init; }
}
