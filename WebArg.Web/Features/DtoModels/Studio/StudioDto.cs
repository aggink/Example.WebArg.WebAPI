﻿namespace WebArg.Web.Features.DtoModels.Studio;

/// <summary>
/// 
/// </summary>
public sealed record StudioDto
{
    /// <summary>
    /// Идентификатор студии
    /// </summary>
    public Guid IsnNode { get; init; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Местоположение
    /// </summary>
    public string Location { get; init; }
}
