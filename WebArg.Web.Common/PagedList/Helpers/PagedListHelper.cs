using WebArg.Web.Common.PagedList.Models;
using X.PagedList;

namespace WebArg.Web.Common.PagedList.Helpers;

/// <summary>
/// Помощник по работе с пагинацией
/// </summary>
public static class PagedListHelper
{
    /// <summary>
    /// Получить список данных из заданного диапазона
    /// </summary>
    /// <param name="items">Список</param>
    /// <param name="pageIndex">Номер страницы</param>
    /// <param name="pageSize">Кол-во элементов на странице</param>
    /// <returns>Список данных из заданного диапазона</returns>
    public static IPagedList<T> GetPagedList<T>(IEnumerable<T> items, int pageIndex, int pageSize)
    {
        if (pageIndex < 1)
            pageIndex = 1;

        if (pageSize < 1)
            pageSize = PageSizeListHelper.DefaultPageSize;

        var pageList = items.ToPagedList(pageIndex, pageSize);

        if (pageList.Count == 0 && pageIndex != 1)
            pageList = items.ToPagedList(1, pageSize);

        return pageList;
    }

    /// <summary>
    /// Получить список данных из заданного диапазона
    /// </summary>
    /// <typeparam name="T">Тип данных</typeparam>
    /// <param name="items">Список данных</param>
    /// <param name="state">Состояние модели</param>
    /// <returns>Список данных из заданного диапазона</returns>
    public static IPagedList<T> GetPagedList<T>(IEnumerable<T> items, ActionState state)
    {
        return GetPagedList(items, state.Page, state.PageSize);
    }
}
