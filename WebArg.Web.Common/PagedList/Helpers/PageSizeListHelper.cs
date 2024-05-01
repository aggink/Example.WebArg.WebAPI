namespace WebArg.Web.Common.PagedList.Helpers;

/// <summary>
/// Базовые данные для пагинации
/// </summary>
public static class PageSizeListHelper
{
    /// <summary>
    /// Начальная страница
    /// </summary>
    public const int DefaultPage = 1;

    /// <summary>
    /// Базовое число элементов списка
    /// </summary>
    public const int DefaultPageSize = 20;

    /// <summary>
    /// Массив стандартных размеров страниц
    /// </summary>
    public static int[] PageSizes => new[]
    {
        20,
        50,
        100,
        200,
        500,
        1000
    };

    /// <summary>
    /// Словарь значений количества элементов
    /// </summary>
    /// <returns>Словарь</returns>
    public static Dictionary<string, string> GetPageSize() =>
        PageSizes.ToDictionary(p => p.ToString(), p => p.ToString());
}
