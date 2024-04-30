using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.Masters.Queries;

/// <summary>
/// Получить мастера для редактирования
/// </summary>
public sealed record GetEditMasterQuery
{
    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    [Required]
    [FromQuery]
    public Guid IsnMaster { get; init; }
}
