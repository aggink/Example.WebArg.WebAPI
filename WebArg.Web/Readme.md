<a name='assembly'></a>
# WebArg.Web

## Contents

- [EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto')
  - [IsnNode](#P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-IsnNode 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-Name 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto.Name')
  - [Qualification](#P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-Qualification 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto.Qualification')
- [EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto')
  - [IsnNode](#P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-IsnNode 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-IsnStudio 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-LastVisit 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto.LastVisit')
  - [Name](#P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-Name 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto.Name')
- [EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto')
  - [IsnNode](#P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-IsnNode 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-Location 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto.Location')
  - [Name](#P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-Name 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto.Name')
- [ErrorResponse](#T-WebArg-Web-Middlewares-DtoModels-ErrorResponse 'WebArg.Web.Middlewares.DtoModels.ErrorResponse')
  - [Code](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Code 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Code')
  - [Details](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Details 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Details')
  - [Message](#P-WebArg-Web-Middlewares-DtoModels-ErrorResponse-Message 'WebArg.Web.Middlewares.DtoModels.ErrorResponse.Message')
- [ExceptionMiddleware](#T-WebArg-Web-Middlewares-ExceptionMiddleware 'WebArg.Web.Middlewares.ExceptionMiddleware')
  - [GetErrorResponse(context,ex)](#M-WebArg-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'WebArg.Web.Middlewares.ExceptionMiddleware.GetErrorResponse(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
- [FluentValidationModelState](#T-WebArg-Web-DataAnnotations-DtoModels-FluentValidationModelState 'WebArg.Web.DataAnnotations.DtoModels.FluentValidationModelState')
  - [Errors](#P-WebArg-Web-DataAnnotations-DtoModels-FluentValidationModelState-Errors 'WebArg.Web.DataAnnotations.DtoModels.FluentValidationModelState.Errors')
- [IMasterManager](#T-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager')
  - [CreateMasterAsync(source,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-CreateMasterAsync-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.CreateMasterAsync(WebArg.Web.Features.Masters.DtoModels.EditMasterDto,System.Threading.CancellationToken)')
  - [DeleteBindWithPersonAsync(model,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-DeleteBindWithPersonAsync-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.DeleteBindWithPersonAsync(WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [DeleteMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-DeleteMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.DeleteMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetInfoMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.GetInfoMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListMasterAsync()](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetListMasterAsync 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.GetListMasterAsync')
  - [GetMasterAsync(isnMaster,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetMasterAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.GetMasterAsync(System.Guid,System.Threading.CancellationToken)')
  - [SetBindWithPersonAsync(model,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-SetBindWithPersonAsync-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.SetBindWithPersonAsync(WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [UpdateMasterAsync(source,cancellationToken)](#M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-UpdateMasterAsync-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Masters.Managers.Interfaces.IMasterManager.UpdateMasterAsync(WebArg.Web.Features.Masters.DtoModels.EditMasterDto,System.Threading.CancellationToken)')
- [IPersonManager](#T-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager')
  - [CreatePersonAsync(source,cancellationToken)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-CreatePersonAsync-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.CreatePersonAsync(WebArg.Web.Features.Persons.DtoModels.EditPersonDto,System.Threading.CancellationToken)')
  - [DeletePersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-DeletePersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.DeletePersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoPersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetInfoPersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.GetInfoPersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListPersonAsync(isnStudio)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetListPersonAsync-System-Nullable{System-Guid}- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.GetListPersonAsync(System.Nullable{System.Guid})')
  - [GetPersonAsync(isnPerson,cancellationToken)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetPersonAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.GetPersonAsync(System.Guid,System.Threading.CancellationToken)')
  - [UpdatePersonAsync(source,cancellationToken)](#M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-UpdatePersonAsync-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Persons.Managers.Interfaces.IPersonManager.UpdatePersonAsync(WebArg.Web.Features.Persons.DtoModels.EditPersonDto,System.Threading.CancellationToken)')
- [IStudioManager](#T-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager')
  - [CreateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.CreateStudioAsync(WebArg.Web.Features.Studios.DtoModels.EditStudioDto,System.Threading.CancellationToken)')
  - [DeleteBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.DeleteBindWithMasterAsync(WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [DeleteStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.DeleteStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.GetInfoStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [GetListStudioAsync()](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetListStudioAsync 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.GetListStudioAsync')
  - [GetStudioAsync(isnStudio,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.GetStudioAsync(System.Guid,System.Threading.CancellationToken)')
  - [SetBindWithMasterAsync(model,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.SetBindWithMasterAsync(WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [UpdateStudioAsync(source,cancellationToken)](#M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Features.Studios.Managers.Interfaces.IStudioManager.UpdateStudioAsync(WebArg.Web.Features.Studios.DtoModels.EditStudioDto,System.Threading.CancellationToken)')
- [InfoMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto')
  - [IsnNode](#P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-IsnNode 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Name 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto.Name')
  - [Persons](#P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Persons 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto.Persons')
  - [Qualification](#P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Qualification 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto.Qualification')
  - [Studios](#P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Studios 'WebArg.Web.Features.Masters.DtoModels.InfoMasterDto.Studios')
- [InfoPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto')
  - [IsnNode](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-IsnNode 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-IsnStudio 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-LastVisit 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.LastVisit')
  - [Masters](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Masters 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.Masters')
  - [Name](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Name 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.Name')
  - [Studio](#P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Studio 'WebArg.Web.Features.Persons.DtoModels.InfoPersonDto.Studio')
- [InfoStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto')
  - [IsnNode](#P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-IsnNode 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Location 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto.Location')
  - [Masters](#P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Masters 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto.Masters')
  - [Name](#P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Name 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto.Name')
  - [Persons](#P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Persons 'WebArg.Web.Features.Studios.DtoModels.InfoStudioDto.Persons')
- [MasterController](#T-WebArg-Web-Controllers-MasterController 'WebArg.Web.Controllers.MasterController')
  - [CreateMaster(model,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-CreateMaster-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.CreateMaster(WebArg.Web.Features.Masters.DtoModels.EditMasterDto,System.Threading.CancellationToken)')
  - [DeleteBindWithPerson(model,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-DeleteBindWithPerson-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.DeleteBindWithPerson(WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [DeleteMaster(isnMaster,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-DeleteMaster-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.DeleteMaster(System.Guid,System.Threading.CancellationToken)')
  - [GetEditMaster(isnMaster,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-GetEditMaster-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.GetEditMaster(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoMaster(isnMaster,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-GetInfoMaster-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.GetInfoMaster(System.Guid,System.Threading.CancellationToken)')
  - [GetListMaster()](#M-WebArg-Web-Controllers-MasterController-GetListMaster 'WebArg.Web.Controllers.MasterController.GetListMaster')
  - [SetBindWithPerson(model,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-SetBindWithPerson-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.SetBindWithPerson(WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto,System.Threading.CancellationToken)')
  - [UpdateMaster(model,cancellationToken)](#M-WebArg-Web-Controllers-MasterController-UpdateMaster-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.MasterController.UpdateMaster(WebArg.Web.Features.Masters.DtoModels.EditMasterDto,System.Threading.CancellationToken)')
- [MasterDto](#T-WebArg-Web-Features-Masters-DtoModels-MasterDto 'WebArg.Web.Features.Masters.DtoModels.MasterDto')
  - [IsnNode](#P-WebArg-Web-Features-Masters-DtoModels-MasterDto-IsnNode 'WebArg.Web.Features.Masters.DtoModels.MasterDto.IsnNode')
  - [Name](#P-WebArg-Web-Features-Masters-DtoModels-MasterDto-Name 'WebArg.Web.Features.Masters.DtoModels.MasterDto.Name')
  - [Qualification](#P-WebArg-Web-Features-Masters-DtoModels-MasterDto-Qualification 'WebArg.Web.Features.Masters.DtoModels.MasterDto.Qualification')
- [MasterManager](#T-WebArg-Web-Features-Masters-Managers-MasterManager 'WebArg.Web.Features.Masters.Managers.MasterManager')
- [MasterMapper](#T-WebArg-Web-Features-Masters-Mappers-MasterMapper 'WebArg.Web.Features.Masters.Mappers.MasterMapper')
- [PersonController](#T-WebArg-Web-Controllers-PersonController 'WebArg.Web.Controllers.PersonController')
  - [CreateРerson(model,cancellationToken)](#M-WebArg-Web-Controllers-PersonController-CreateРerson-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.CreateРerson(WebArg.Web.Features.Persons.DtoModels.EditPersonDto,System.Threading.CancellationToken)')
  - [DeleteРerson(isnPerson,cancellationToken)](#M-WebArg-Web-Controllers-PersonController-DeleteРerson-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.DeleteРerson(System.Guid,System.Threading.CancellationToken)')
  - [GetEditPerson(isnPerson,cancellationToken)](#M-WebArg-Web-Controllers-PersonController-GetEditPerson-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.GetEditPerson(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoPerson(isnPerson,cancellationToken)](#M-WebArg-Web-Controllers-PersonController-GetInfoPerson-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.GetInfoPerson(System.Guid,System.Threading.CancellationToken)')
  - [GetListPerson(cancellationToken)](#M-WebArg-Web-Controllers-PersonController-GetListPerson-System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.GetListPerson(System.Threading.CancellationToken)')
  - [UpdatePerson(model,cancellationToken)](#M-WebArg-Web-Controllers-PersonController-UpdatePerson-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.PersonController.UpdatePerson(WebArg.Web.Features.Persons.DtoModels.EditPersonDto,System.Threading.CancellationToken)')
- [PersonDto](#T-WebArg-Web-Features-Persons-DtoModels-PersonDto 'WebArg.Web.Features.Persons.DtoModels.PersonDto')
  - [IsnNode](#P-WebArg-Web-Features-Persons-DtoModels-PersonDto-IsnNode 'WebArg.Web.Features.Persons.DtoModels.PersonDto.IsnNode')
  - [IsnStudio](#P-WebArg-Web-Features-Persons-DtoModels-PersonDto-IsnStudio 'WebArg.Web.Features.Persons.DtoModels.PersonDto.IsnStudio')
  - [LastVisit](#P-WebArg-Web-Features-Persons-DtoModels-PersonDto-LastVisit 'WebArg.Web.Features.Persons.DtoModels.PersonDto.LastVisit')
  - [Name](#P-WebArg-Web-Features-Persons-DtoModels-PersonDto-Name 'WebArg.Web.Features.Persons.DtoModels.PersonDto.Name')
- [PersonManager](#T-WebArg-Web-Features-Persons-Managers-PersonManager 'WebArg.Web.Features.Persons.Managers.PersonManager')
- [PersonMapper](#T-WebArg-Web-Features-Persons-Mappers-PersonMapper 'WebArg.Web.Features.Persons.Mappers.PersonMapper')
- [ServiceCollectionExtensions](#T-WebArg-Web-Extensions-ServiceCollectionExtensions 'WebArg.Web.Extensions.ServiceCollectionExtensions')
  - [AddAutoMappers(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddAutoMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddAutoMappers(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddDatabase(services,configuration)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddDatabase-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddDatabase(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)')
  - [AddFeaturesServices(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFeaturesServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddFeaturesServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddFluentValidationSetup(services,type)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddFluentValidationSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Type)')
  - [AddSwaggerSetup(services)](#M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.Web.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [SetBindWithMasterDto](#T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto')
  - [IsnMaster](#P-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto-IsnMaster 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto.IsnMaster')
  - [IsnStudio](#P-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto-IsnStudio 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto.IsnStudio')
- [SetBindWithPersonDto](#T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto')
  - [IsnMaster](#P-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto-IsnMaster 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto.IsnMaster')
  - [IsnPerson](#P-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto-IsnPerson 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto.IsnPerson')
- [StudioController](#T-WebArg-Web-Controllers-StudioController 'WebArg.Web.Controllers.StudioController')
  - [CreateStudio(model,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-CreateStudio-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.CreateStudio(WebArg.Web.Features.Studios.DtoModels.EditStudioDto,System.Threading.CancellationToken)')
  - [DeleteBindWithMaster(model,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-DeleteBindWithMaster-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.DeleteBindWithMaster(WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [DeleteStudio(isnStudio,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-DeleteStudio-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.DeleteStudio(System.Guid,System.Threading.CancellationToken)')
  - [GetEditStudio(isnStudio,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-GetEditStudio-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.GetEditStudio(System.Guid,System.Threading.CancellationToken)')
  - [GetInfoStudio(isnStudio,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-GetInfoStudio-System-Guid,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.GetInfoStudio(System.Guid,System.Threading.CancellationToken)')
  - [GetListStudios()](#M-WebArg-Web-Controllers-StudioController-GetListStudios 'WebArg.Web.Controllers.StudioController.GetListStudios')
  - [SetBindWithMaster(model,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-SetBindWithMaster-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.SetBindWithMaster(WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto,System.Threading.CancellationToken)')
  - [UpdateStudio(model,cancellationToken)](#M-WebArg-Web-Controllers-StudioController-UpdateStudio-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken- 'WebArg.Web.Controllers.StudioController.UpdateStudio(WebArg.Web.Features.Studios.DtoModels.EditStudioDto,System.Threading.CancellationToken)')
- [StudioDto](#T-WebArg-Web-Features-Studios-DtoModels-StudioDto 'WebArg.Web.Features.Studios.DtoModels.StudioDto')
  - [IsnNode](#P-WebArg-Web-Features-Studios-DtoModels-StudioDto-IsnNode 'WebArg.Web.Features.Studios.DtoModels.StudioDto.IsnNode')
  - [Location](#P-WebArg-Web-Features-Studios-DtoModels-StudioDto-Location 'WebArg.Web.Features.Studios.DtoModels.StudioDto.Location')
  - [Name](#P-WebArg-Web-Features-Studios-DtoModels-StudioDto-Name 'WebArg.Web.Features.Studios.DtoModels.StudioDto.Name')
- [StudioManager](#T-WebArg-Web-Features-Studios-Managers-StudioManager 'WebArg.Web.Features.Studios.Managers.StudioManager')
- [StudioMapper](#T-WebArg-Web-Features-Studios-Mappers-StudioMapper 'WebArg.Web.Features.Studios.Mappers.StudioMapper')
- [ValidateUsingFluentValidationAttribute](#T-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute 'WebArg.Web.DataAnnotations.ValidateUsingFluentValidationAttribute')
  - [GetBadRequestResult(validationResult)](#M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult- 'WebArg.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.GetBadRequestResult(FluentValidation.Results.ValidationResult)')
  - [IsCustomType(type)](#M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type- 'WebArg.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.IsCustomType(System.Type)')
  - [ToFluentModelState(validationResult)](#M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult- 'WebArg.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.ToFluentModelState(FluentValidation.Results.ValidationResult)')

<a name='T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto'></a>
## EditMasterDto `type`

##### Namespace

WebArg.Web.Features.Masters.DtoModels

##### Summary

Модель для редактирования мастера

<a name='P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-Masters-DtoModels-EditMasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Специализация

<a name='T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto'></a>
## EditPersonDto `type`

##### Namespace

WebArg.Web.Features.Persons.DtoModels

##### Summary

Модель клиента для редактирования

<a name='P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-Persons-DtoModels-EditPersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto'></a>
## EditStudioDto `type`

##### Namespace

WebArg.Web.Features.Studios.DtoModels

##### Summary

Модель студии для редактирования

<a name='P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-Studios-DtoModels-EditStudioDto-Name'></a>
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

<a name='T-WebArg-Web-DataAnnotations-DtoModels-FluentValidationModelState'></a>
## FluentValidationModelState `type`

##### Namespace

WebArg.Web.DataAnnotations.DtoModels

##### Summary

Описание ошибок

<a name='P-WebArg-Web-DataAnnotations-DtoModels-FluentValidationModelState-Errors'></a>
### Errors `property`

##### Summary

Ошибки валидации

<a name='T-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager'></a>
## IMasterManager `type`

##### Namespace

WebArg.Web.Features.Masters.Managers.Interfaces

##### Summary

Интерфейс обработчика [](#!-Master 'Master')

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-CreateMasterAsync-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken-'></a>
### CreateMasterAsync(source,cancellationToken) `method`

##### Summary

Создание мастера

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Masters.DtoModels.EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-DeleteBindWithPersonAsync-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithPersonAsync(model,cancellationToken) `method`

##### Summary

Удалить связь между мастером и клиентом

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto](#T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto') | Модель связи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-DeleteMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetInfoMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetListMasterAsync'></a>
### GetListMasterAsync() `method`

##### Summary

Получить список мастеров

##### Returns

Список мастеров

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-GetMasterAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-SetBindWithPersonAsync-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### SetBindWithPersonAsync(model,cancellationToken) `method`

##### Summary

Установить связь между мастером и клиентом

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto](#T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto') | Модель связи |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Masters-Managers-Interfaces-IMasterManager-UpdateMasterAsync-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken-'></a>
### UpdateMasterAsync(source,cancellationToken) `method`

##### Summary

Обновить данные мастера

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Masters.DtoModels.EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager'></a>
## IPersonManager `type`

##### Namespace

WebArg.Web.Features.Persons.Managers.Interfaces

##### Summary

Интерфейс обработчика [](#!-Person 'Person')

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-CreatePersonAsync-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken-'></a>
### CreatePersonAsync(source,cancellationToken) `method`

##### Summary

Создать клиента

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Persons.DtoModels.EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-DeletePersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetInfoPersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetListPersonAsync-System-Nullable{System-Guid}-'></a>
### GetListPersonAsync(isnStudio) `method`

##### Summary

Получить список клиентов

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | Идентификатор студии |

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-GetPersonAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Persons-Managers-Interfaces-IPersonManager-UpdatePersonAsync-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken-'></a>
### UpdatePersonAsync(source,cancellationToken) `method`

##### Summary

Обновить данные клиента

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Persons.DtoModels.EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager'></a>
## IStudioManager `type`

##### Namespace

WebArg.Web.Features.Studios.Managers.Interfaces

##### Summary

Интерфейс обработчика [](#!-Studio 'Studio')

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-CreateStudioAsync-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken-'></a>
### CreateStudioAsync(source,cancellationToken) `method`

##### Summary

Создать студию

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Studios.DtoModels.EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto') | Студия |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-DeleteBindWithMasterAsync-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithMasterAsync(model,cancellationToken) `method`

##### Summary

Удалить связь между студией и мастером

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto](#T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto') | Связь между студией и мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-DeleteStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetInfoStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetListStudioAsync'></a>
### GetListStudioAsync() `method`

##### Summary

Получить список студий

##### Returns

Список студий

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-GetStudioAsync-System-Guid,System-Threading-CancellationToken-'></a>
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

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-SetBindWithMasterAsync-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### SetBindWithMasterAsync(model,cancellationToken) `method`

##### Summary

Установить связь между студией и мастером

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto](#T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto') | Связь между студией и мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Features-Studios-Managers-Interfaces-IStudioManager-UpdateStudioAsync-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken-'></a>
### UpdateStudioAsync(source,cancellationToken) `method`

##### Summary

Обновить данные студии

##### Returns

Данные об операции

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [WebArg.Web.Features.Studios.DtoModels.EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto') | Студия |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto'></a>
## InfoMasterDto `type`

##### Namespace

WebArg.Web.Features.Masters.DtoModels

##### Summary

Полные данные о мастере

<a name='P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Persons'></a>
### Persons `property`

##### Summary

Список прикрепленных клиентов

<a name='P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Квалификация

<a name='P-WebArg-Web-Features-Masters-DtoModels-InfoMasterDto-Studios'></a>
### Studios `property`

##### Summary

Список прикрепленных студий

<a name='T-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto'></a>
## InfoPersonDto `type`

##### Namespace

WebArg.Web.Features.Persons.DtoModels

##### Summary

Полные данные о клиенте

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Masters'></a>
### Masters `property`

##### Summary

Список мастеров

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-Persons-DtoModels-InfoPersonDto-Studio'></a>
### Studio `property`

##### Summary

Студия закрепленная за клиентом

<a name='T-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto'></a>
## InfoStudioDto `type`

##### Namespace

WebArg.Web.Features.Studios.DtoModels

##### Summary

Полные данные о студии

<a name='P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Masters'></a>
### Masters `property`

##### Summary

Список мастеров

<a name='P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='P-WebArg-Web-Features-Studios-DtoModels-InfoStudioDto-Persons'></a>
### Persons `property`

##### Summary

Список клиентов

<a name='T-WebArg-Web-Controllers-MasterController'></a>
## MasterController `type`

##### Namespace

WebArg.Web.Controllers

##### Summary

Контроллер - мастера

<a name='M-WebArg-Web-Controllers-MasterController-CreateMaster-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken-'></a>
### CreateMaster(model,cancellationToken) `method`

##### Summary

Создать мастера

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-DeleteBindWithPerson-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithPerson(model,cancellationToken) `method`

##### Summary

Удалить связь между мастером и клиентом

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto](#T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto') | Настройка связи между мастером и клиентом |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-DeleteMaster-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteMaster(isnMaster,cancellationToken) `method`

##### Summary

Удалить мастера

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-GetEditMaster-System-Guid,System-Threading-CancellationToken-'></a>
### GetEditMaster(isnMaster,cancellationToken) `method`

##### Summary

Получить данные мастера для редактирования

##### Returns

Данные мастера для редактирования

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-GetInfoMaster-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoMaster(isnMaster,cancellationToken) `method`

##### Summary

Получить полную информацию о мастере

##### Returns

Полная информация о мастере

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnMaster | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор мастера |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-GetListMaster'></a>
### GetListMaster() `method`

##### Summary

Получить список мастеров

##### Returns

Список мастеров

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Controllers-MasterController-SetBindWithPerson-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto,System-Threading-CancellationToken-'></a>
### SetBindWithPerson(model,cancellationToken) `method`

##### Summary

Установить связь между мастером и клиентом

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto](#T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto 'WebArg.Web.Features.Masters.DtoModels.SetBindWithPersonDto') | Настройка связи между мастером и клиентом |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-MasterController-UpdateMaster-WebArg-Web-Features-Masters-DtoModels-EditMasterDto,System-Threading-CancellationToken-'></a>
### UpdateMaster(model,cancellationToken) `method`

##### Summary

Обновить данные мастера

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Masters.DtoModels.EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto') | Мастер |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Masters-DtoModels-MasterDto'></a>
## MasterDto `type`

##### Namespace

WebArg.Web.Features.Masters.DtoModels

##### Summary

Мастер

<a name='P-WebArg-Web-Features-Masters-DtoModels-MasterDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-Masters-DtoModels-MasterDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Web-Features-Masters-DtoModels-MasterDto-Qualification'></a>
### Qualification `property`

##### Summary

Квалификация

<a name='T-WebArg-Web-Features-Masters-Managers-MasterManager'></a>
## MasterManager `type`

##### Namespace

WebArg.Web.Features.Masters.Managers

##### Summary

Менеджер обработки [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')

<a name='T-WebArg-Web-Features-Masters-Mappers-MasterMapper'></a>
## MasterMapper `type`

##### Namespace

WebArg.Web.Features.Masters.Mappers

##### Summary

Настройка проецирования моделей [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master'), [MasterDto](#T-WebArg-Web-Features-Masters-DtoModels-MasterDto 'WebArg.Web.Features.Masters.DtoModels.MasterDto'), [EditMasterDto](#T-WebArg-Web-Features-Masters-DtoModels-EditMasterDto 'WebArg.Web.Features.Masters.DtoModels.EditMasterDto')

<a name='T-WebArg-Web-Controllers-PersonController'></a>
## PersonController `type`

##### Namespace

WebArg.Web.Controllers

##### Summary

Контроллер - клиент

<a name='M-WebArg-Web-Controllers-PersonController-CreateРerson-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken-'></a>
### CreateРerson(model,cancellationToken) `method`

##### Summary

Создать клиента

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Persons.DtoModels.EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-PersonController-DeleteРerson-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteРerson(isnPerson,cancellationToken) `method`

##### Summary

Удалить клиента

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-PersonController-GetEditPerson-System-Guid,System-Threading-CancellationToken-'></a>
### GetEditPerson(isnPerson,cancellationToken) `method`

##### Summary

Получить данные клиента для редактирования

##### Returns

Данные клиента для редактирования

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-PersonController-GetInfoPerson-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoPerson(isnPerson,cancellationToken) `method`

##### Summary

Получить полную информацию о клиенте

##### Returns

Полная информация о клиенте

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор клиента |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-PersonController-GetListPerson-System-Threading-CancellationToken-'></a>
### GetListPerson(cancellationToken) `method`

##### Summary

Получить список клиентов

##### Returns

Список клиентов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-PersonController-UpdatePerson-WebArg-Web-Features-Persons-DtoModels-EditPersonDto,System-Threading-CancellationToken-'></a>
### UpdatePerson(model,cancellationToken) `method`

##### Summary

Обновить данные клиента

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Persons.DtoModels.EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto') | Клиент |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Persons-DtoModels-PersonDto'></a>
## PersonDto `type`

##### Namespace

WebArg.Web.Features.Persons.DtoModels

##### Summary

Клиент

<a name='P-WebArg-Web-Features-Persons-DtoModels-PersonDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Web-Features-Persons-DtoModels-PersonDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Persons-DtoModels-PersonDto-LastVisit'></a>
### LastVisit `property`

##### Summary

Дата последнего визита

<a name='P-WebArg-Web-Features-Persons-DtoModels-PersonDto-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='T-WebArg-Web-Features-Persons-Managers-PersonManager'></a>
## PersonManager `type`

##### Namespace

WebArg.Web.Features.Persons.Managers

##### Summary

Менеджер обработки [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')

<a name='T-WebArg-Web-Features-Persons-Mappers-PersonMapper'></a>
## PersonMapper `type`

##### Namespace

WebArg.Web.Features.Persons.Mappers

##### Summary

Настройка проецирования моделей [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person'), [PersonDto](#T-WebArg-Web-Features-Persons-DtoModels-PersonDto 'WebArg.Web.Features.Persons.DtoModels.PersonDto'), [EditPersonDto](#T-WebArg-Web-Features-Persons-DtoModels-EditPersonDto 'WebArg.Web.Features.Persons.DtoModels.EditPersonDto')

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

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddDatabase-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### AddDatabase(services,configuration) `method`

##### Summary

Регистрация контекст базы данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFeaturesServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddFeaturesServices(services) `method`

##### Summary

Регистрация сервисов Web

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type-'></a>
### AddFluentValidationSetup(services,type) `method`

##### Summary

Регистрация FluentValidation в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Глобальный тип для поиска валидаторов |

<a name='M-WebArg-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddSwaggerSetup(services) `method`

##### Summary

Регистрация Swagger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto'></a>
## SetBindWithMasterDto `type`

##### Namespace

WebArg.Web.Features.Studios.DtoModels

##### Summary

Связь студии с мастером

<a name='P-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='T-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto'></a>
## SetBindWithPersonDto `type`

##### Namespace

WebArg.Web.Features.Masters.DtoModels

##### Summary

Связь мастера с клиентом

<a name='P-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Web-Features-Masters-DtoModels-SetBindWithPersonDto-IsnPerson'></a>
### IsnPerson `property`

##### Summary

Идентификатор клиента

<a name='T-WebArg-Web-Controllers-StudioController'></a>
## StudioController `type`

##### Namespace

WebArg.Web.Controllers

##### Summary

Контроллер - студия

<a name='M-WebArg-Web-Controllers-StudioController-CreateStudio-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken-'></a>
### CreateStudio(model,cancellationToken) `method`

##### Summary

Создать студию

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-DeleteBindWithMaster-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### DeleteBindWithMaster(model,cancellationToken) `method`

##### Summary

Удалить связь между студией и мастером

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto](#T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto') | Настройка связи студии с мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-DeleteStudio-System-Guid,System-Threading-CancellationToken-'></a>
### DeleteStudio(isnStudio,cancellationToken) `method`

##### Summary

Удалить студию

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-GetEditStudio-System-Guid,System-Threading-CancellationToken-'></a>
### GetEditStudio(isnStudio,cancellationToken) `method`

##### Summary

Получить данные о студии

##### Returns

Данные о студии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-GetInfoStudio-System-Guid,System-Threading-CancellationToken-'></a>
### GetInfoStudio(isnStudio,cancellationToken) `method`

##### Summary

Получить полную информацию о студии

##### Returns

Полная информация о студии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isnStudio | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Идентификатор студии |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-GetListStudios'></a>
### GetListStudios() `method`

##### Summary

Получить список студий

##### Returns

Список студий

##### Parameters

This method has no parameters.

<a name='M-WebArg-Web-Controllers-StudioController-SetBindWithMaster-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto,System-Threading-CancellationToken-'></a>
### SetBindWithMaster(model,cancellationToken) `method`

##### Summary

Установить связь между студией и мастером

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto](#T-WebArg-Web-Features-Studios-DtoModels-SetBindWithMasterDto 'WebArg.Web.Features.Studios.DtoModels.SetBindWithMasterDto') | Настройка связи студии с мастером |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-Web-Controllers-StudioController-UpdateStudio-WebArg-Web-Features-Studios-DtoModels-EditStudioDto,System-Threading-CancellationToken-'></a>
### UpdateStudio(model,cancellationToken) `method`

##### Summary

Обновить данные студии

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [WebArg.Web.Features.Studios.DtoModels.EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto') | Студия |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-Web-Features-Studios-DtoModels-StudioDto'></a>
## StudioDto `type`

##### Namespace

WebArg.Web.Features.Studios.DtoModels

##### Summary

Студия

<a name='P-WebArg-Web-Features-Studios-DtoModels-StudioDto-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Web-Features-Studios-DtoModels-StudioDto-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Web-Features-Studios-DtoModels-StudioDto-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='T-WebArg-Web-Features-Studios-Managers-StudioManager'></a>
## StudioManager `type`

##### Namespace

WebArg.Web.Features.Studios.Managers

##### Summary

Менеджер обработки [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')

<a name='T-WebArg-Web-Features-Studios-Mappers-StudioMapper'></a>
## StudioMapper `type`

##### Namespace

WebArg.Web.Features.Studios.Mappers

##### Summary

Настройка проецирования моделей [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio'), [StudioDto](#T-WebArg-Web-Features-Studios-DtoModels-StudioDto 'WebArg.Web.Features.Studios.DtoModels.StudioDto'), [EditStudioDto](#T-WebArg-Web-Features-Studios-DtoModels-EditStudioDto 'WebArg.Web.Features.Studios.DtoModels.EditStudioDto')

<a name='T-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute'></a>
## ValidateUsingFluentValidationAttribute `type`

##### Namespace

WebArg.Web.DataAnnotations

##### Summary

Настройка автоматической валидации входных параметров через FluentValidation

##### Remarks

Доступен для переопределения

<a name='M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult-'></a>
### GetBadRequestResult(validationResult) `method`

##### Summary

Переопределение фильтров возвращаемых через BadRequestObjectResult

##### Returns

Объект, который используется в конструкторе

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |

<a name='M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type-'></a>
### IsCustomType(type) `method`

##### Summary

Проверка является ли тип DTO

##### Returns

True - тип является DTO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Тип модели |

<a name='M-WebArg-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult-'></a>
### ToFluentModelState(validationResult) `method`

##### Summary

Получить модуль с описанием ошибок

##### Returns

Описание ошибок

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |
