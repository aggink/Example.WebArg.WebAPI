# Простое WEB-API приложение

### Функциональность:
- Таблица Studio:
  * Получение списка студий (GetListStudios)
  * Получение полной информации о студии (GetInfoStudio)
  * Получение данных студии для редактирования (GetEditStudio)
  * Создание студии (CreateStudio)
  * Редактирование данных студии (UpdateStudio)
  * Удаление студии (DeleteStudio)
  * Установка связи между студией и мастером (SetBindWithMaster)
  * Удаление связи между студией и мастером (DeleteBindWithMaster)
- Таблица Master:
  * Получение списка мастеров (GetListMaster)
  * Получение полной информации о мастере (GetInfoMaster)
  * Получение данных мастера для редактирования (GetEditMaster)
  * Создание мастера (CreateMaster)
  * Редактирование данных мастера (UpdateMaster)
  * Удаление мастера (DeleteMaster)
  * Установка связи между мастером и клиентом (SetBindWithPerson)
  * Удаление связи между мастером и клиентом (DeleteBindWithPerson)
- Таблица Person:
  * Получение списка клиентов (GetListPerson)
  * Получение полной информации о клиенте (GetInfoPerson)
  * Получение данных клиента для редактирования (GetEditPerson)
  * Создание клиента (CreateРerson)
  * Редактирование данных клиента (UpdatePerson)
  * Удаление клиента (DeleteРerson)
 
### Используемые библиотеки:
- AutoMapper
- Microsoft.AspNetCore.Mvc.NewtonsoftJson
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Serilog.AspNetCore
- Swashbuckle.AspNetCore
- Swashbuckle.AspNetCore.Annotations
- Vsxmd
- X.PagedList
- X.PagedList.Mvc.Core
