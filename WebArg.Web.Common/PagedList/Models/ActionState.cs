using WebArg.Web.Common.PagedList.Helpers;

namespace WebArg.Web.Common.PagedList.Models;

/// <summary>
/// Состояние модели (фильтры)
/// </summary>
[Serializable]
public class ActionState
{
    /// <summary>
    /// Номер страницы
    /// </summary>
    public int Page { get; set; } = PageSizeListHelper.DefaultPage;

    /// <summary>
    /// Количество элементов на страницы
    /// </summary>
    public int PageSize { get; set; } = PageSizeListHelper.DefaultPageSize;

    /// <summary>
    /// Порядок сортировки
    /// </summary>
    public int Order { get; set; } = 1;

    /// <summary>
    /// Поле сортировки
    /// </summary>
    public string OrderField { get; set; }
}
