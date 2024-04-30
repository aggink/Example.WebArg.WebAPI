using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Masters.Queries;

/// <summary>
/// Получить полную информацию о мастере
/// </summary>
public sealed record GetInfoMasterQuery
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnMaster { get; init; }
}
