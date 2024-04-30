<a name='assembly'></a>
# WebArg.Web

## Contents

- [EditMasterDto](#T-WebArg-Web-Features-DtoModels-Master-EditMasterDto 'WebArg.Web.Features.DtoModels.Master.EditMasterDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-IsnNode 'WebArg.Web.Features.DtoModels.Master.EditMasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-Name 'WebArg.Web.Features.DtoModels.Master.EditMasterDto.Name')
  - [Qualification](#P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-Qualification 'WebArg.Web.Features.DtoModels.Master.EditMasterDto.Qualification')
- [EditPersonDto](#T-WebArg-Web-Features-DtoModels-Person-EditPersonDto 'WebArg.Web.Features.DtoModels.Person.EditPersonDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-IsnNode 'WebArg.Web.Features.DtoModels.Person.EditPersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-IsnStudio 'WebArg.Web.Features.DtoModels.Person.EditPersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-LastVisit 'WebArg.Web.Features.DtoModels.Person.EditPersonDto.LastVisit')
  - [Name](#P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-Name 'WebArg.Web.Features.DtoModels.Person.EditPersonDto.Name')
- [EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-IsnNode 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-Location 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto.Location')
  - [Name](#P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-Name 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto.Name')
- [ErrorResponse](#T-WebArg-Web-Middlewares-DtoModels-ErrorResponse 'WebArg.Web.Middlewares.DtoModels.ErrorResponse')
  - [Code](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Code 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Code')
  - [Details](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Details 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Details')
  - [Message](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Message 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Message')
- [ExceptionMiddleware](#T-WebArg-Web-Middlewares-ExceptionMiddleware 'WebArg.Web.Middlewares.ExceptionMiddleware')
  - [GetErrorResponse(context,ex)](#M-WebArg-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'WebArg.Web.Middlewares.ExceptionMiddleware.GetErrorResponse(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
- [IMasterManager](#T-WebArg-Web-Features-Interfaces-IMasterManager 'WebArg.Web.Features.Interfaces.IMasterManager')
  - [CreateMasterAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-CreateMasterAsync-WebArg-Web-Features-DtoModels-Master-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.CreateMasterAsync(WebArg.Web.Features.DtoModels.Master.EditMasterDto,System.Threading.CancellationToken)')
  - [DeleteBindWithPersonAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-DeleteBindWithPersonAsync-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.DeleteBindWithPersonAsync(WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [DeleteMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-DeleteMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.DeleteMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-GetInfoMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.GetInfoMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListMasterAsync()](#M-WebArg-Web-Features-Interfaces-IMasterManager-GetListMasterAsync 'WebArg.Web.Features.Interfaces.IMasterManager.GetListMasterAsync')
  - [GetMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-GetMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.GetMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [SetBindWithPersonAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-SetBindWithPersonAsync-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.SetBindWithPersonAsync(WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [UpdateMasterAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IMasterManager-UpdateMasterAsync-WebArg-Web-Features-DtoModels-Master-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IMasterManager.UpdateMasterAsync(WebArg.Web.Features.DtoModels.Master.EditMasterDto,System.Threading.CancellationToken)')
- [IPersonManager](#T-WebArg-Web-Features-Interfaces-IPersonManager 'WebArg.Web.Features.Interfaces.IPersonManager')
  - [CreatePersonAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IPersonManager-CreatePersonAsync-WebArg-Web-Features-DtoModels-Person-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IPersonManager.CreatePersonAsync(WebArg.Web.Features.DtoModels.Person.EditPersonDto,System.Threading.CancellationToken)')
  - [DeletePersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IPersonManager-DeletePersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IPersonManager.DeletePersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoPersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IPersonManager-GetInfoPersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IPersonManager.GetInfoPersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListPersonAsync(isnStudio)](#M-WebArg-Web-Features-Interfaces-IPersonManager-GetListPersonAsync-System-Nullable{System-Guid}- 'WebArg.Web.Features.Interfaces.IPersonManager.GetListPersonAsync(System.Nullable{System.Guid})')
  - [GetPersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IPersonManager-GetPersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IPersonManager.GetPersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [UpdatePersonAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IPersonManager-UpdatePersonAsync-WebArg-Web-Features-DtoModels-Person-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IPersonManager.UpdatePersonAsync(WebArg.Web.Features.DtoModels.Person.EditPersonDto,System.Threading.CancellationToken)')
- [IStudioManager](#T-WebArg-Web-Features-Interfaces-IStudioManager 'WebArg.Web.Features.Interfaces.IStudioManager')
  - [CreateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.CreateStudioAsync(WebArg.Web.Features.DtoModels.Studio.EditStudioDto,System.Threading.CancellationToken)')
  - [DeleteBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.DeleteBindWithMasterAsync(WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [DeleteStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.DeleteStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.GetInfoStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListStudioAsync()](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetListStudioAsync 'WebArg.Web.Features.Interfaces.IStudioManager.GetListStudioAsync')
  - [GetStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.GetStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [SetBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.SetBindWithMasterAsync(WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [UpdateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Interfaces.IStudioManager.UpdateStudioAsync(WebArg.Web.Features.DtoModels.Studio.EditStudioDto,System.Threading.CancellationToken)')
- [InfoMasterDto](#T-WebArg-Web-Features-DtoModels-Master-InfoMasterDto 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-IsnNode 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Name 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto.Name')
  - [Persons](#P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Persons 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto.Persons')
  - [Qualification](#P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Qualification 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto.Qualification')
  - [Studios](#P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Studios 'WebArg.Web.Features.DtoModels.Master.InfoMasterDto.Studios')
- [InfoPersonDto](#T-WebArg-Web-Features-DtoModels-Person-InfoPersonDto 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-IsnNode 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-IsnStudio 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-LastVisit 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.LastVisit')
  - [Masters](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Masters 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.Masters')
  - [Name](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Name 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.Name')
  - [Studio](#P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Studio 'WebArg.Web.Features.DtoModels.Person.InfoPersonDto.Studio')
- [InfoStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-IsnNode 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Location 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto.Location')
  - [Masters](#P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Masters 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto.Masters')
  - [Name](#P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Name 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto.Name')
  - [Persons](#P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Persons 'WebArg.Web.Features.DtoModels.Studio.InfoStudioDto.Persons')
- [MasterDto](#T-WebArg-Web-Features-DtoModels-Master-MasterDto 'WebArg.Web.Features.DtoModels.Master.MasterDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Master-MasterDto-IsnNode 'WebArg.Web.Features.DtoModels.Master.MasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-DtoModels-Master-MasterDto-Name 'WebArg.Web.Features.DtoModels.Master.MasterDto.Name')
  - [Qualification](#P-WebArg-Web-Features-DtoModels-Master-MasterDto-Qualification 'WebArg.Web.Features.DtoModels.Master.MasterDto.Qualification')
- [MasterManager](#T-WebArg-Web-Features-Managers-MasterManager 'WebArg.Web.Features.Managers.MasterManager')
- [MasterMapper](#T-WebArg-Web-Features-Mappers-MasterMapper 'WebArg.Web.Features.Mappers.MasterMapper')
- [PersonDto](#T-WebArg-Web-Features-DtoModels-Person-PersonDto 'WebArg.Web.Features.DtoModels.Person.PersonDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Person-PersonDto-IsnNode 'WebArg.Web.Features.DtoModels.Person.PersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-DtoModels-Person-PersonDto-IsnStudio 'WebArg.Web.Features.DtoModels.Person.PersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-DtoModels-Person-PersonDto-LastVisit 'WebArg.Web.Features.DtoModels.Person.PersonDto.LastVisit')
  - [Name](#P-WebArg-Web-Features-DtoModels-Person-PersonDto-Name 'WebArg.Web.Features.DtoModels.Person.PersonDto.Name')
- [PersonManager](#T-WebArg-Web-Features-Managers-PersonManager 'WebArg.Web.Features.Managers.PersonManager')
- [PersonMapper](#T-WebArg-Web-Features-Mappers-PersonMapper 'WebArg.Web.Features.Mappers.PersonMapper')
- [ServiceCollectionExtensions](#T-WebArg-Web-Extensions-ServiceCollectionExtensions 'WebArg.Web.Extensions.ServiceCollectionExtensions')
  - [AddAutoMappers(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddAutoMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddAutoMappers(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddFeaturesServices(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFeaturesServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddFeaturesServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddSwaggerSetup(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [SetBindWithMasterDto](#T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto')
  - [IsnMaster](#P-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto-IsnMaster 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto.IsnMaster')
  - [IsnStudio](#P-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto-IsnStudio 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto.IsnStudio')
- [SetBindWithPersonDto](#T-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto 'WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto')
  - [IsnMaster](#P-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto-IsnMaster 'WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto.IsnMaster')
  - [IsnPerson](#P-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto-IsnPerson 'WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto.IsnPerson')
- [StudioDto](#T-WebArg-Web-Features-DtoModels-Studio-StudioDto 'WebArg.Web.Features.DtoModels.Studio.StudioDto')
  - [IsnNode](#P-WebArg-Web-Features-DtoModels-Studio-StudioDto-IsnNode 'WebArg.Web.Features.DtoModels.Studio.StudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-DtoModels-Studio-StudioDto-Location 'WebArg.Web.Features.DtoModels.Studio.StudioDto.Location')
  - [Name](#P-WebArg-Web-Features-DtoModels-Studio-StudioDto-Name 'WebArg.Web.Features.DtoModels.Studio.StudioDto.Name')
- [StudioManager](#T-WebArg-Web-Features-Managers-StudioManager 'WebArg.Web.Features.Managers.StudioManager')
- [StudioMapper](#T-WebArg-Web-Features-Mappers-StudioMapper 'WebArg.Web.Features.Mappers.StudioMapper')

<a name='T-WebArg-Web-Features-DtoModels-Master-EditMasterDto'></a>
## EditMasterDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Master

##### Summary

Модель для редактирования мастера

<a name='P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-DtoModels-Master-EditMasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Специализация

<a name='T-WebArg-Web-Features-DtoModels-Person-EditPersonDto'></a>
## EditPersonDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Person

##### Summary

Модель клиента для редактирования

<a name='P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-DtoModels-Person-EditPersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto'></a>
## EditStudioDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Studio

##### Summary

Модель студии для редактирования

<a name='P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-DtoModels-Studio-EditStudioDto-Name'></a>
### Name `property`

##### Summary

Наименование

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

<a name='T-WebArg-Web-Features-Interfaces-IMasterManager'></a>
## IMasterManager `type`

##### Namespace

WebArg.Web.Features.Interfaces

##### Summary

Интерфейс обработчика [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-CreateMasterAsync-WebArg-Web-Features-DtoModels-Master-EditMasterDto,System-Threading-CancellationToken-'></a>
### CreateMasterAsync(source,cancellationToken) `method`

##### Summary

Создание мастера

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Master.EditMasterDto](#T-WebArg-Web-Features-DtoModels-Master-EditMasterDto 'WebArg.Web.Features.DtoModels.Master.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-DeleteBindWithPersonAsync-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithPersonAsync(model,cancellationToken) `method`

##### Summary

Удалить связь между мастером и клиентом

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto](#T-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto 'WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto') | Модель связи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-DeleteMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteMasterAsync(isnMaster,cancellationToken) `method`

##### Summary

Удалить мастера

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор матера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-GetInfoMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoMasterAsync(isnMaster,cancellationToken) `method`

##### Summary

Получить полную информацию о мастере

##### Returns

Полная информация о мастере

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-GetListMasterAsync'></a>
### GetListMasterAsync() `method`

##### Summary

Получить список мастеров

##### Returns

Список мастеров

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-GetMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetMasterAsync(isnMaster,cancellationToken) `method`

##### Summary

Получить данные мастера

##### Returns

Данные мастера

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-SetBindWithPersonAsync-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### SetBindWithPersonAsync(model,cancellationToken) `method`

##### Summary

Установить связь между мастером и клиентом

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto](#T-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto 'WebArg.Web.Features.DtoModels.Master.SetBindWithPersonDto') | Модель связи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IMasterManager-UpdateMasterAsync-WebArg-Web-Features-DtoModels-Master-EditMasterDto,System-Threading-CancellationToken-'></a>
### UpdateMasterAsync(source,cancellationToken) `method`

##### Summary

Обновить данные мастера

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Master.EditMasterDto](#T-WebArg-Web-Features-DtoModels-Master-EditMasterDto 'WebArg.Web.Features.DtoModels.Master.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Interfaces-IPersonManager'></a>
## IPersonManager `type`

##### Namespace

WebArg.Web.Features.Interfaces

##### Summary

Интерфейс обработчика [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-CreatePersonAsync-WebArg-Web-Features-DtoModels-Person-EditPersonDto,System-Threading-CancellationToken-'></a>
### CreatePersonAsync(source,cancellationToken) `method`

##### Summary

Создать клиента

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Person.EditPersonDto](#T-WebArg-Web-Features-DtoModels-Person-EditPersonDto 'WebArg.Web.Features.DtoModels.Person.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-DeletePersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
### DeletePersonAsync(isnPerson,cancellationToken) `method`

##### Summary

Удалить клиента

##### Returns

Удаленный клиент

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-GetInfoPersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoPersonAsync(isnPerson,cancellationToken) `method`

##### Summary

Получить полные данные о клиенте

##### Returns

Полные данные о клиенте

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-GetListPersonAsync-System-Nullable{System-Guid}-'></a>
### GetListPersonAsync(isnStudio) `method`

##### Summary

Получить список клиентов

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | Идентификатор студии |

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-GetPersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetPersonAsync(isnPerson,cancellationToken) `method`

##### Summary

Получить данные клиента

##### Returns

Данные клиента

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IPersonManager-UpdatePersonAsync-WebArg-Web-Features-DtoModels-Person-EditPersonDto,System-Threading-CancellationToken-'></a>
### UpdatePersonAsync(source,cancellationToken) `method`

##### Summary

Обновить данные клиента

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Person.EditPersonDto](#T-WebArg-Web-Features-DtoModels-Person-EditPersonDto 'WebArg.Web.Features.DtoModels.Person.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Interfaces-IStudioManager'></a>
## IStudioManager `type`

##### Namespace

WebArg.Web.Features.Interfaces

##### Summary

Интерфейс обработчика [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken-'></a>
### CreateStudioAsync(source,cancellationToken) `method`

##### Summary

Создать студию

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Studio.EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto') | Студия |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithMasterAsync(model,cancellationToken) `method`

##### Summary

Удалить связь между студией и мастером

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto](#T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto') | Связь между студией и мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteStudioAsync(isnStudio,cancellationToken) `method`

##### Summary

Удалить студию

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoStudioAsync(isnStudio,cancellationToken) `method`

##### Summary

Получить полные данные о студии

##### Returns

Полные данные о студии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetListStudioAsync'></a>
### GetListStudioAsync() `method`

##### Summary

Получить список студий

##### Returns

Список студий

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
### GetStudioAsync(isnStudio,cancellationToken) `method`

##### Summary

Получить студию

##### Returns

Студия

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### SetBindWithMasterAsync(model,cancellationToken) `method`

##### Summary

Установить связь между студией и мастером

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto](#T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto 'WebArg.Web.Features.DtoModels.Studio.SetBindWithMasterDto') | Связь между студией и мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-DtoModels-Studio-EditStudioDto,System-Threading-CancellationToken-'></a>
### UpdateStudioAsync(source,cancellationToken) `method`

##### Summary

Обновить данные студии

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.DtoModels.Studio.EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto') | Студия |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-DtoModels-Master-InfoMasterDto'></a>
## InfoMasterDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Master

##### Summary

Полные данные о мастере

<a name='P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Persons'></a>
### Persons `property`

##### Summary

Список прикрепленных клиентов

<a name='P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Квалификация

<a name='P-WebArg-Web-Features-DtoModels-Master-InfoMasterDto-Studios'></a>
### Studios `property`

##### Summary

Список прикрепленных студий

<a name='T-WebArg-Web-Features-DtoModels-Person-InfoPersonDto'></a>
## InfoPersonDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Person

##### Summary

Полные данные о клиенте

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Masters'></a>
### Masters `property`

##### Summary

Список мастеров

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-DtoModels-Person-InfoPersonDto-Studio'></a>
### Studio `property`

##### Summary

Студия закрепленная за клиентом

<a name='T-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto'></a>
## InfoStudioDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Studio

##### Summary

Полные данные о студии

<a name='P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Masters'></a>
### Masters `property`

##### Summary

Список мастеров

<a name='P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='P-WebArg-Web-Features-DtoModels-Studio-InfoStudioDto-Persons'></a>
### Persons `property`

##### Summary

Список клиентов

<a name='T-WebArg-Web-Features-DtoModels-Master-MasterDto'></a>
## MasterDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Master

##### Summary

Мастер

<a name='P-WebArg-Web-Features-DtoModels-Master-MasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-DtoModels-Master-MasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-DtoModels-Master-MasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Квалификация

<a name='T-WebArg-Web-Features-Managers-MasterManager'></a>
## MasterManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='T-WebArg-Web-Features-Mappers-MasterMapper'></a>
## MasterMapper `type`

##### Namespace

WebArg.Web.Features.Mappers

##### Summary

Настройка проецирования моделей [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master'), [MasterDto](#T-WebArg-Web-Features-DtoModels-Master-MasterDto 'WebArg.Web.Features.DtoModels.Master.MasterDto'), [EditMasterDto](#T-WebArg-Web-Features-DtoModels-Master-EditMasterDto 'WebArg.Web.Features.DtoModels.Master.EditMasterDto')

<a name='T-WebArg-Web-Features-DtoModels-Person-PersonDto'></a>
## PersonDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Person

##### Summary

Клиент

<a name='P-WebArg-Web-Features-DtoModels-Person-PersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-DtoModels-Person-PersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Person-PersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-DtoModels-Person-PersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='T-WebArg-Web-Features-Managers-PersonManager'></a>
## PersonManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='T-WebArg-Web-Features-Mappers-PersonMapper'></a>
## PersonMapper `type`

##### Namespace

WebArg.Web.Features.Mappers

##### Summary

Настройка проецирования моделей [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person'), [PersonDto](#T-WebArg-Web-Features-DtoModels-Person-PersonDto 'WebArg.Web.Features.DtoModels.Person.PersonDto'), [EditPersonDto](#T-WebArg-Web-Features-DtoModels-Person-EditPersonDto 'WebArg.Web.Features.DtoModels.Person.EditPersonDto')

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

<a name='T-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto'></a>
## SetBindWithMasterDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Studio

##### Summary

Связь студии с мастером

<a name='P-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-DtoModels-Studio-SetBindWithMasterDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='T-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto'></a>
## SetBindWithPersonDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Master

##### Summary

Связь мастера с клиентом

<a name='P-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-DtoModels-Master-SetBindWithPersonDto-IsnPerson'></a>
### IsnPerson `property`

##### Summary

Идентификатор клиента

<a name='T-WebArg-Web-Features-DtoModels-Studio-StudioDto'></a>
## StudioDto `type`

##### Namespace

WebArg.Web.Features.DtoModels.Studio

##### Summary



<a name='P-WebArg-Web-Features-DtoModels-Studio-StudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-DtoModels-Studio-StudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-DtoModels-Studio-StudioDto-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='T-WebArg-Web-Features-Managers-StudioManager'></a>
## StudioManager `type`

##### Namespace

WebArg.Web.Features.Managers

##### Summary

Менеджер обработки [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='T-WebArg-Web-Features-Mappers-StudioMapper'></a>
## StudioMapper `type`

##### Namespace

WebArg.Web.Features.Mappers

##### Summary

Настройка проецирования моделей [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio'), [StudioDto](#T-WebArg-Web-Features-DtoModels-Studio-StudioDto 'WebArg.Web.Features.DtoModels.Studio.StudioDto'), [EditStudioDto](#T-WebArg-Web-Features-DtoModels-Studio-EditStudioDto 'WebArg.Web.Features.DtoModels.Studio.EditStudioDto')
