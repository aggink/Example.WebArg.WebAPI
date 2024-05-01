<a name='assembly'></a>
# WebArg.Logic

## Contents

- [IMasterService](#T-WebArg-Logic-Interfaces-Services-IMasterService 'WebArg.Logic.Interfaces.Services.IMasterService')
  - [DeleteBindWithPersonAsync(dataContext,isnMaster,isnPerson,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IMasterService-DeleteBindWithPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IMasterService.DeleteBindWithPersonAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Guid,System.Threading.CancellationToken)')
  - [GetInfoMasterAsync(dataContext,isnMaster,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IMasterService-GetInfoMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IMasterService.GetInfoMasterAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Threading.CancellationToken)')
  - [GetMasterQueryable(dataContext)](#M-WebArg-Logic-Interfaces-Services-IMasterService-GetMasterQueryable-WebArg-Storage-Database-DataContext- 'WebArg.Logic.Interfaces.Services.IMasterService.GetMasterQueryable(WebArg.Storage.Database.DataContext)')
  - [SetBindWithPersonAsync(dataContext,isnMaster,isnPerson,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IMasterService-SetBindWithPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IMasterService.SetBindWithPersonAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Guid,System.Threading.CancellationToken)')
- [IPersonService](#T-WebArg-Logic-Interfaces-Services-IPersonService 'WebArg.Logic.Interfaces.Services.IPersonService')
  - [GetInfoPersonAsync(dataContext,isnPerson,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IPersonService-GetInfoPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IPersonService.GetInfoPersonAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Threading.CancellationToken)')
  - [GetPersonQueryable(dataContext,filter)](#M-WebArg-Logic-Interfaces-Services-IPersonService-GetPersonQueryable-WebArg-Storage-Database-DataContext,WebArg-Logic-DtoModels-PersonFilter- 'WebArg.Logic.Interfaces.Services.IPersonService.GetPersonQueryable(WebArg.Storage.Database.DataContext,WebArg.Logic.DtoModels.PersonFilter)')
- [IRepository\`1](#T-WebArg-Logic-Interfaces-Repositories-IRepository`1 'WebArg.Logic.Interfaces.Repositories.IRepository`1')
  - [Create(dataContext,model)](#M-WebArg-Logic-Interfaces-Repositories-IRepository`1-Create-WebArg-Storage-Database-DataContext,`0- 'WebArg.Logic.Interfaces.Repositories.IRepository`1.Create(WebArg.Storage.Database.DataContext,`0)')
  - [DeleteAsync(dataContext,isnNode,cancellationToken)](#M-WebArg-Logic-Interfaces-Repositories-IRepository`1-DeleteAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Repositories.IRepository`1.DeleteAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Threading.CancellationToken)')
  - [GetByIdAsync(dataContext,isnNode,cancellationToken)](#M-WebArg-Logic-Interfaces-Repositories-IRepository`1-GetByIdAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Repositories.IRepository`1.GetByIdAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Threading.CancellationToken)')
  - [UpdateAsync(dataContext,model,cancellationToken)](#M-WebArg-Logic-Interfaces-Repositories-IRepository`1-UpdateAsync-WebArg-Storage-Database-DataContext,`0,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Repositories.IRepository`1.UpdateAsync(WebArg.Storage.Database.DataContext,`0,System.Threading.CancellationToken)')
- [IStudioService](#T-WebArg-Logic-Interfaces-Services-IStudioService 'WebArg.Logic.Interfaces.Services.IStudioService')
  - [DeleteBindWithMasterAsync(dataContext,isnStudio,isnMaster,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IStudioService-DeleteBindWithMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IStudioService.DeleteBindWithMasterAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Guid,System.Threading.CancellationToken)')
  - [GetInfoStudioAsync(dataContext,isnStudio,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IStudioService-GetInfoStudioAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IStudioService.GetInfoStudioAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Threading.CancellationToken)')
  - [GetStudioQueryable(dataContext)](#M-WebArg-Logic-Interfaces-Services-IStudioService-GetStudioQueryable-WebArg-Storage-Database-DataContext- 'WebArg.Logic.Interfaces.Services.IStudioService.GetStudioQueryable(WebArg.Storage.Database.DataContext)')
  - [SetBindWithMasterAsync(dataContext,isnStudio,isnMaster,cancellationToken)](#M-WebArg-Logic-Interfaces-Services-IStudioService-SetBindWithMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken- 'WebArg.Logic.Interfaces.Services.IStudioService.SetBindWithMasterAsync(WebArg.Storage.Database.DataContext,System.Guid,System.Guid,System.Threading.CancellationToken)')
- [LogicException](#T-WebArg-Logic-Exceptions-LogicException 'WebArg.Logic.Exceptions.LogicException')
- [MasterRepository](#T-WebArg-Logic-Repositories-MasterRepository 'WebArg.Logic.Repositories.MasterRepository')
- [MasterService](#T-WebArg-Logic-Services-MasterService 'WebArg.Logic.Services.MasterService')
- [PersonFilter](#T-WebArg-Logic-DtoModels-PersonFilter 'WebArg.Logic.DtoModels.PersonFilter')
  - [IsnStudio](#P-WebArg-Logic-DtoModels-PersonFilter-IsnStudio 'WebArg.Logic.DtoModels.PersonFilter.IsnStudio')
- [PersonRepository](#T-WebArg-Logic-Repositories-PersonRepository 'WebArg.Logic.Repositories.PersonRepository')
- [PersonService](#T-WebArg-Logic-Services-PersonService 'WebArg.Logic.Services.PersonService')
- [ServiceCollectionExtensions](#T-WebArg-Logic-Extensions-ServiceCollectionExtensions 'WebArg.Logic.Extensions.ServiceCollectionExtensions')
  - [AddLogicServices(services)](#M-WebArg-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Logic.Extensions.ServiceCollectionExtensions.AddLogicServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [StudioRepository](#T-WebArg-Logic-Repositories-StudioRepository 'WebArg.Logic.Repositories.StudioRepository')
- [StudioService](#T-WebArg-Logic-Services-StudioService 'WebArg.Logic.Services.StudioService')

<a name='T-WebArg-Logic-Interfaces-Services-IMasterService'></a>
## IMasterService `type`

##### Namespace

WebArg.Logic.Interfaces.Services

##### Summary

Сервис для модели [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='M-WebArg-Logic-Interfaces-Services-IMasterService-DeleteBindWithPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken-'></a>
### DeleteBindWithPersonAsync(dataContext,isnMaster,isnPerson,cancellationToken) `method`

##### Summary

Удалить связь мастером и клиента

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Services-IMasterService-GetInfoMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoMasterAsync(dataContext,isnMaster,cancellationToken) `method`

##### Summary

Получить информацию о мастере

##### Returns

Информация о мастере

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор матера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Services-IMasterService-GetMasterQueryable-WebArg-Storage-Database-DataContext-'></a>
### GetMasterQueryable(dataContext) `method`

##### Summary

Получить список мастеров

##### Returns

Список мастеров

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |

<a name='M-WebArg-Logic-Interfaces-Services-IMasterService-SetBindWithPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken-'></a>
### SetBindWithPersonAsync(dataContext,isnMaster,isnPerson,cancellationToken) `method`

##### Summary

Установить связь между мастером и клиентом

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Logic-Interfaces-Services-IPersonService'></a>
## IPersonService `type`

##### Namespace

WebArg.Logic.Interfaces.Services

##### Summary

Сервис для модели [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='M-WebArg-Logic-Interfaces-Services-IPersonService-GetInfoPersonAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoPersonAsync(dataContext,isnPerson,cancellationToken) `method`

##### Summary

Получить информацию о клиенте

##### Returns

Информация о клиенте

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Services-IPersonService-GetPersonQueryable-WebArg-Storage-Database-DataContext,WebArg-Logic-DtoModels-PersonFilter-'></a>
### GetPersonQueryable(dataContext,filter) `method`

##### Summary

Список клиентов

##### Returns

Получить список клиентов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| filter | [WebArg.Logic.DtoModels.PersonFilter](#T-WebArg-Logic-DtoModels-PersonFilter 'WebArg.Logic.DtoModels.PersonFilter') | Фильтры |

<a name='T-WebArg-Logic-Interfaces-Repositories-IRepository`1'></a>
## IRepository\`1 `type`

##### Namespace

WebArg.Logic.Interfaces.Repositories

##### Summary

CRUD методы с моделью

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | Тип модели |

<a name='M-WebArg-Logic-Interfaces-Repositories-IRepository`1-Create-WebArg-Storage-Database-DataContext,`0-'></a>
### Create(dataContext,model) `method`

##### Summary

Добавить запись в базу данных

##### Returns

Запись добавленная в базу данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| model | [\`0](#T-`0 '`0') | Модель |

<a name='M-WebArg-Logic-Interfaces-Repositories-IRepository`1-DeleteAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken-'></a>
### DeleteAsync(dataContext,isnNode,cancellationToken) `method`

##### Summary

Удалить запись из базу данных

##### Returns

Удаленная запись из базы данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnNode | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор записи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Repositories-IRepository`1-GetByIdAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken-'></a>
### GetByIdAsync(dataContext,isnNode,cancellationToken) `method`

##### Summary

Получить запись

##### Returns

Запись

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnNode | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор записи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Repositories-IRepository`1-UpdateAsync-WebArg-Storage-Database-DataContext,`0,System-Threading-CancellationToken-'></a>
### UpdateAsync(dataContext,model,cancellationToken) `method`

##### Summary

Обновить запись в базе данных

##### Returns

Обновленная запись в базе данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| model | [\`0](#T-`0 '`0') | Модель |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Logic-Interfaces-Services-IStudioService'></a>
## IStudioService `type`

##### Namespace

WebArg.Logic.Interfaces.Services

##### Summary

Сервис для [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='M-WebArg-Logic-Interfaces-Services-IStudioService-DeleteBindWithMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken-'></a>
### DeleteBindWithMasterAsync(dataContext,isnStudio,isnMaster,cancellationToken) `method`

##### Summary

Удалить связь студии с мастером

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Services-IStudioService-GetInfoStudioAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoStudioAsync(dataContext,isnStudio,cancellationToken) `method`

##### Summary

Получить информацию о студии

##### Returns

Информация о студии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Logic-Interfaces-Services-IStudioService-GetStudioQueryable-WebArg-Storage-Database-DataContext-'></a>
### GetStudioQueryable(dataContext) `method`

##### Summary

Получить список студий

##### Returns

Список студий

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |

<a name='M-WebArg-Logic-Interfaces-Services-IStudioService-SetBindWithMasterAsync-WebArg-Storage-Database-DataContext,System-Guid,System-Guid,System-Threading-CancellationToken-'></a>
### SetBindWithMasterAsync(dataContext,isnStudio,isnMaster,cancellationToken) `method`

##### Summary

Связать студию с мастером

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.Storage.Database.DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') | Контекст базы данных |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Logic-Exceptions-LogicException'></a>
## LogicException `type`

##### Namespace

WebArg.Logic.Exceptions

##### Summary

Выброшенная ошибка разработчиком

<a name='T-WebArg-Logic-Repositories-MasterRepository'></a>
## MasterRepository `type`

##### Namespace

WebArg.Logic.Repositories

##### Summary

CRUD методы для [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='T-WebArg-Logic-Services-MasterService'></a>
## MasterService `type`

##### Namespace

WebArg.Logic.Services

##### Summary

Сервис для [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='T-WebArg-Logic-DtoModels-PersonFilter'></a>
## PersonFilter `type`

##### Namespace

WebArg.Logic.DtoModels

##### Summary

Фильтры для [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='P-WebArg-Logic-DtoModels-PersonFilter-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='T-WebArg-Logic-Repositories-PersonRepository'></a>
## PersonRepository `type`

##### Namespace

WebArg.Logic.Repositories

##### Summary

CRUD методы для [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='T-WebArg-Logic-Services-PersonService'></a>
## PersonService `type`

##### Namespace

WebArg.Logic.Services

##### Summary

Сервис для [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='T-WebArg-Logic-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.Logic.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-WebArg-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddLogicServices(services) `method`

##### Summary

Регистрация сервисов библиотеки Logic

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-WebArg-Logic-Repositories-StudioRepository'></a>
## StudioRepository `type`

##### Namespace

WebArg.Logic.Repositories

##### Summary

CRUD методы для [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='T-WebArg-Logic-Services-StudioService'></a>
## StudioService `type`

##### Namespace

WebArg.Logic.Services

##### Summary

Сервис для [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')
