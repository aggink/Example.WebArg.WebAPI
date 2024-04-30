using System.Text.Json.Serialization;

namespace WebArg.Web.Middlewares.DtoModels;

/// <summary>
/// Сообщение об ошибке
/// </summary>
public sealed record ErrorResponse
{
    /// <summary>
    /// Код ошибки
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; init; }

    /// <summary>
    /// Сообщение
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; init; }

    /// <summary>
    /// Детали
    /// </summary>
    [JsonPropertyName("details")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object Details { get; init; }
}
