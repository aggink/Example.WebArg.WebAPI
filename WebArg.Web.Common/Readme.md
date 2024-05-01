<a name='assembly'></a>
# WebArg.Web.Common

## Contents

- [ActionState](#T-WebArg-Web-Common-PagedList-Models-ActionState 'WebArg.Web.Common.PagedList.Models.ActionState')
  - [Order](#P-WebArg-Web-Common-PagedList-Models-ActionState-Order 'WebArg.Web.Common.PagedList.Models.ActionState.Order')
  - [OrderField](#P-WebArg-Web-Common-PagedList-Models-ActionState-OrderField 'WebArg.Web.Common.PagedList.Models.ActionState.OrderField')
  - [Page](#P-WebArg-Web-Common-PagedList-Models-ActionState-Page 'WebArg.Web.Common.PagedList.Models.ActionState.Page')
  - [PageSize](#P-WebArg-Web-Common-PagedList-Models-ActionState-PageSize 'WebArg.Web.Common.PagedList.Models.ActionState.PageSize')
- [ActionStateHelper](#T-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper 'Marketplace.Web.Common.PagedList.Helpers.ActionStateHelper')
  - [GetActionState\`\`1(actionStateQuery)](#M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-GetActionState``1-``0- 'Marketplace.Web.Common.PagedList.Helpers.ActionStateHelper.GetActionState``1(``0)')
  - [SetActionStateDefault\`\`1(actionState)](#M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-SetActionStateDefault``1-``0- 'Marketplace.Web.Common.PagedList.Helpers.ActionStateHelper.SetActionStateDefault``1(``0)')
  - [SetActionState\`\`2(actionState,actionStateQuery)](#M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-SetActionState``2-``0,``1- 'Marketplace.Web.Common.PagedList.Helpers.ActionStateHelper.SetActionState``2(``0,``1)')
- [ActionStateQuery](#T-WebArg-Web-Common-PagedList-Models-ActionStateQuery 'WebArg.Web.Common.PagedList.Models.ActionStateQuery')
  - [Order](#P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-Order 'WebArg.Web.Common.PagedList.Models.ActionStateQuery.Order')
  - [OrderField](#P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-OrderField 'WebArg.Web.Common.PagedList.Models.ActionStateQuery.OrderField')
  - [PageIndex](#P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-PageIndex 'WebArg.Web.Common.PagedList.Models.ActionStateQuery.PageIndex')
  - [PageSize](#P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-PageSize 'WebArg.Web.Common.PagedList.Models.ActionStateQuery.PageSize')
- [PageSizeListHelper](#T-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper 'WebArg.Web.Common.PagedList.Helpers.PageSizeListHelper')
  - [DefaultPage](#F-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-DefaultPage 'WebArg.Web.Common.PagedList.Helpers.PageSizeListHelper.DefaultPage')
  - [DefaultPageSize](#F-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-DefaultPageSize 'WebArg.Web.Common.PagedList.Helpers.PageSizeListHelper.DefaultPageSize')
  - [PageSizes](#P-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-PageSizes 'WebArg.Web.Common.PagedList.Helpers.PageSizeListHelper.PageSizes')
  - [GetPageSize()](#M-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-GetPageSize 'WebArg.Web.Common.PagedList.Helpers.PageSizeListHelper.GetPageSize')
- [PagedListHelper](#T-WebArg-Web-Common-PagedList-Helpers-PagedListHelper 'WebArg.Web.Common.PagedList.Helpers.PagedListHelper')
  - [GetPagedList\`\`1(items,pageIndex,pageSize)](#M-WebArg-Web-Common-PagedList-Helpers-PagedListHelper-GetPagedList``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32- 'WebArg.Web.Common.PagedList.Helpers.PagedListHelper.GetPagedList``1(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Int32)')
  - [GetPagedList\`\`1(items,state)](#M-WebArg-Web-Common-PagedList-Helpers-PagedListHelper-GetPagedList``1-System-Collections-Generic-IEnumerable{``0},WebArg-Web-Common-PagedList-Models-ActionState- 'WebArg.Web.Common.PagedList.Helpers.PagedListHelper.GetPagedList``1(System.Collections.Generic.IEnumerable{``0},WebArg.Web.Common.PagedList.Models.ActionState)')

<a name='T-WebArg-Web-Common-PagedList-Models-ActionState'></a>
## ActionState `type`

##### Namespace

WebArg.Web.Common.PagedList.Models

##### Summary

Состояние модели (фильтры)

<a name='P-WebArg-Web-Common-PagedList-Models-ActionState-Order'></a>
### Order `property`

##### Summary

Порядок сортировки

<a name='P-WebArg-Web-Common-PagedList-Models-ActionState-OrderField'></a>
### OrderField `property`

##### Summary

Поле сортировки

<a name='P-WebArg-Web-Common-PagedList-Models-ActionState-Page'></a>
### Page `property`

##### Summary

Номер страницы

<a name='P-WebArg-Web-Common-PagedList-Models-ActionState-PageSize'></a>
### PageSize `property`

##### Summary

Количество элементов на страницы

<a name='T-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper'></a>
## ActionStateHelper `type`

##### Namespace

Marketplace.Web.Common.PagedList.Helpers

##### Summary

Помощник в настройке состояний моделей

<a name='M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-GetActionState``1-``0-'></a>
### GetActionState\`\`1(actionStateQuery) `method`

##### Summary

Получить состояние модели

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionStateQuery | [\`\`0](#T-``0 '``0') | Данные пользовательского запроса |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T2 | Тип пользовательского запроса |

<a name='M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-SetActionStateDefault``1-``0-'></a>
### SetActionStateDefault\`\`1(actionState) `method`

##### Summary

Установка начальных значений состояния модели

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionState | [\`\`0](#T-``0 '``0') | Состояние модели |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | Тип состояния модели |

<a name='M-Marketplace-Web-Common-PagedList-Helpers-ActionStateHelper-SetActionState``2-``0,``1-'></a>
### SetActionState\`\`2(actionState,actionStateQuery) `method`

##### Summary

Установка значений состояния модели

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionState | [\`\`0](#T-``0 '``0') | Состояние модели |
| actionStateQuery | [\`\`1](#T-``1 '``1') | Данные пользовательского запроса |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | Тип состояния модели |
| T2 | Тип пользовательского запроса |

<a name='T-WebArg-Web-Common-PagedList-Models-ActionStateQuery'></a>
## ActionStateQuery `type`

##### Namespace

WebArg.Web.Common.PagedList.Models

##### Summary

Состояние модели

<a name='P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-Order'></a>
### Order `property`

##### Summary

Порядок сортировки

<a name='P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-OrderField'></a>
### OrderField `property`

##### Summary

Поле сортировки

<a name='P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-PageIndex'></a>
### PageIndex `property`

##### Summary

Страница

<a name='P-WebArg-Web-Common-PagedList-Models-ActionStateQuery-PageSize'></a>
### PageSize `property`

##### Summary

Размер страницы

<a name='T-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper'></a>
## PageSizeListHelper `type`

##### Namespace

WebArg.Web.Common.PagedList.Helpers

##### Summary

Базовые данные для пагинации

<a name='F-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-DefaultPage'></a>
### DefaultPage `constants`

##### Summary

Начальная страница

<a name='F-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-DefaultPageSize'></a>
### DefaultPageSize `constants`

##### Summary

Базовое число элементов списка

<a name='P-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-PageSizes'></a>
### PageSizes `property`

##### Summary

Массив стандартных размеров страниц

<a name='M-WebArg-Web-Common-PagedList-Helpers-PageSizeListHelper-GetPageSize'></a>
### GetPageSize() `method`

##### Summary

Словарь значений количества элементов

##### Returns

Словарь

##### Parameters

This method has no parameters.

<a name='T-WebArg-Web-Common-PagedList-Helpers-PagedListHelper'></a>
## PagedListHelper `type`

##### Namespace

WebArg.Web.Common.PagedList.Helpers

##### Summary

Помощник по работе с пагинацией

<a name='M-WebArg-Web-Common-PagedList-Helpers-PagedListHelper-GetPagedList``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32-'></a>
### GetPagedList\`\`1(items,pageIndex,pageSize) `method`

##### Summary

Получить список данных из заданного диапазона

##### Returns

Список данных из заданного диапазона

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Список |
| pageIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Номер страницы |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Кол-во элементов на странице |

<a name='M-WebArg-Web-Common-PagedList-Helpers-PagedListHelper-GetPagedList``1-System-Collections-Generic-IEnumerable{``0},WebArg-Web-Common-PagedList-Models-ActionState-'></a>
### GetPagedList\`\`1(items,state) `method`

##### Summary

Получить список данных из заданного диапазона

##### Returns

Список данных из заданного диапазона

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Список данных |
| state | [WebArg.Web.Common.PagedList.Models.ActionState](#T-WebArg-Web-Common-PagedList-Models-ActionState 'WebArg.Web.Common.PagedList.Models.ActionState') | Состояние модели |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип данных |
