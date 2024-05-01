using WebArg.Web.Common.PagedList.Helpers;
using WebArg.Web.Common.PagedList.Models;

namespace Marketplace.Web.Common.PagedList.Helpers;

/// <summary>
/// Помощник в настройке состояний моделей 
/// </summary>
public static class ActionStateHelper
{
    /// <summary>
    /// Установка значений состояния модели
    /// </summary>
    /// <typeparam name="T1">Тип состояния модели</typeparam>
    /// <typeparam name="T2">Тип пользовательского запроса</typeparam>
    /// <param name="actionState">Состояние модели</param>
    /// <param name="actionStateQuery">Данные пользовательского запроса</param>
    public static void SetActionState<T1, T2>(T1 actionState, T2 actionStateQuery)
        where T1 : ActionState
        where T2 : ActionStateQuery
    {
        if (actionStateQuery.PageIndex.HasValue)
            actionState.Page = actionStateQuery.PageIndex.Value;

        if (actionStateQuery.PageSize.HasValue)
            actionState.PageSize = actionStateQuery.PageSize.Value;

        if (actionStateQuery.Order.HasValue)
            actionState.Order = actionStateQuery.Order.Value;

        if (!string.IsNullOrEmpty(actionStateQuery.OrderField))
            actionState.OrderField = actionStateQuery.OrderField;
    }

    /// <summary>
    /// Получить состояние модели
    /// </summary>
    /// <typeparam name="T2">Тип пользовательского запроса</typeparam>
    /// <param name="actionStateQuery">Данные пользовательского запроса</param>
    public static ActionState GetActionState<T2>(T2 actionStateQuery)
        where T2 : ActionStateQuery
    {
        var actionState = new ActionState();

        if (actionStateQuery.PageIndex.HasValue)
            actionState.Page = actionStateQuery.PageIndex.Value;

        if (actionStateQuery.PageSize.HasValue)
            actionState.PageSize = actionStateQuery.PageSize.Value;

        if (actionStateQuery.Order.HasValue)
            actionState.Order = actionStateQuery.Order.Value;

        if (!string.IsNullOrEmpty(actionStateQuery.OrderField))
            actionState.OrderField = actionStateQuery.OrderField;

        return actionState;
    }

    /// <summary>
    /// Установка начальных значений состояния модели
    /// </summary>
    /// <typeparam name="T1">Тип состояния модели</typeparam>
    /// <param name="actionState">Состояние модели</param>
    public static void SetActionStateDefault<T1>(T1 actionState)
        where T1 : ActionState
    {
        actionState.Page = PageSizeListHelper.DefaultPage;
        actionState.PageSize = PageSizeListHelper.DefaultPageSize;
        actionState.Order = 1;
        actionState.OrderField = null;
    }
}
