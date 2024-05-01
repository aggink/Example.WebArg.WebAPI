namespace WebArg.Web.Common.PagedList.Models;

/// <summary>
/// Состояние модели
/// </summary>
public class ActionStateQuery
{
    /// <summary>
    /// Страница
    /// </summary>
    public int? PageIndex { get; set; }

    /// <summary>
    /// Размер страницы
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Порядок сортировки
    /// </summary>
    public int? Order { get; set; }

    /// <summary>
    /// Поле сортировки
    /// </summary>
    public string OrderField { get; set; }
}
