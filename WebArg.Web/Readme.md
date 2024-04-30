<a name='assembly'></a>
# WebArg.Web

## Contents

- [ErrorResponse](#T-WebArg-Web-Middlewares-DtoModels-ErrorResponse 'WebArg.Web.Middlewares.DtoModels.ErrorResponse')
  - [Code](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Code 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Code')
  - [Details](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Details 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Details')
  - [Message](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Message 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Message')
- [ExceptionMiddleware](#T-WebArg-Web-Middlewares-ExceptionMiddleware 'WebArg.Web.Middlewares.ExceptionMiddleware')
  - [GetErrorResponse(context,ex)](#M-WebArg-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'WebArg.Web.Middlewares.ExceptionMiddleware.GetErrorResponse(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
- [IStudioManager](#T-WebArg-Web-Features-Interfaces-IStudioManager 'WebArg.Web.Features.Interfaces.IStudioManager')
  - [CreateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.CreateStudioAsync(WebArg.Web.Features.DtoModels.Studio.EditStudioDto,System.Threading.CancellationToken)')
  - [DeleteBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.DeleteBindWithMasterAsync(WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [DeleteStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.DeleteStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.GetInfoStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListStudioAsync()](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetListStudioAsync 'WebArg.Web.Features.Interfaces.IStudioManager.GetListStudioAsync')
  - [GetStudioAsync(isnStudio)](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.GetStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [SetBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.SetBindWithMasterAsync(WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [UpdateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.UpdateStudioAsync(WebArg.Web.Features.DtoModels.Studio.EditStudioDto,System.Threading.CancellationToken)')
- [MasterManager](#T-WebArg-Web-Features-Managers-MasterManager 'WebArg.Web.Features.Managers.MasterManager')
- [PersonManager](#T-WebArg-Web-Features-Managers-PersonManager 'WebArg.Web.Features.Managers.PersonManager')
- [ServiceCollectionExtensions](#T-WebArg-Web-Extensions-ServiceCollectionExtensions 'WebArg.Web.Extensions.ServiceCollectionExtensions')
  - [AddAutoMappers(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddAutoMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddAutoMappers(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddFeaturesServices(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFeaturesServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddFeaturesServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddSwaggerSetup(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [StudioManager](#T-WebArg-Web-Features-Managers-StudioManager 'WebArg.Web.Features.Managers.StudioManager')

<a name='T-WebArg-Web-Middlewares-DtoModels-ErrorResponse'></a>
## ErrorResponse `type`

##### Namespace

WebArg.Web.Middlewares.DtoModels

##### Summary

Сообщение об ошибке

<a name='P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Code'></a>
### Code `property`

##### Summary

Код ошибки

<a name='P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Details'></a>
### Details `property`

##### Summary

Детали

<a name='P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Message'></a>
### Message `property`

##### Summary

Сообщение

<a name='T-WebArg-Web-Middlewares-ExceptionMiddleware'></a>
## ExceptionMiddleware `type`

##### Namespace

WebArg.Web.Middlewares

##### Summary

Обработчик ошибок

<a name='M-WebArg-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception-'></a>
### GetErrorResponse(context,ex) `method`

##### Summary

Получить описание ошибки

##### Returns

Описание ошибки

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | HttpContext |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Ошибка |

<a name='T-WebArg-Web-Features-Interfaces-IStudioManager'></a>
## IStudioManager `type`

##### Namespace

WebArg.Web.Features.Interfaces

##### Summary

Интерфейс обработчика [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken-'></a>
### CreateStudioAsync(source,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Studio.EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithMasterAsync(model,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto](#T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteStudioAsync(isnStudio,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoStudioAsync(isnStudio,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetListStudioAsync'></a>
### GetListStudioAsync() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetStudioAsync(isnStudio) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### SetBindWithMasterAsync(model,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto](#T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken-'></a>
### UpdateStudioAsync(source,cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Studio.EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='T-WebArg-Web-Features-Managers-MasterManager'></a>
## MasterManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='T-WebArg-Web-Features-Managers-PersonManager'></a>
## PersonManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='T-WebArg-Web-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.Web.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddAutoMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddAutoMappers(services) `method`

##### Summary

Регистрация mappers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFeaturesServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddFeaturesServices(services) `method`

##### Summary

Регистрация сервисов Web

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddSwaggerSetup(services) `method`

##### Summary

Регистрация Swagger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-WebArg-Web-Features-Managers-StudioManager'></a>
## StudioManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')
