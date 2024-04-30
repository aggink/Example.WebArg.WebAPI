<a name='assembly'></a>
# WebArg.Storage

## Contents

- [DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext')
  - [Masters](#P-WebArg-Storage-Database-DataContext-Masters 'WebArg.Storage.Database.DataContext.Masters')
  - [MastersPersons](#P-WebArg-Storage-Database-DataContext-MastersPersons 'WebArg.Storage.Database.DataContext.MastersPersons')
  - [Persons](#P-WebArg-Storage-Database-DataContext-Persons 'WebArg.Storage.Database.DataContext.Persons')
  - [Studios](#P-WebArg-Storage-Database-DataContext-Studios 'WebArg.Storage.Database.DataContext.Studios')
  - [StudiosMasters](#P-WebArg-Storage-Database-DataContext-StudiosMasters 'WebArg.Storage.Database.DataContext.StudiosMasters')
- [Master](#T-WebArg-Storage-Models-Master 'WebArg.Storage.Models.Master')
  - [IsnNode](#P-WebArg-Storage-Models-Master-IsnNode 'WebArg.Storage.Models.Master.IsnNode')
  - [MasterPersons](#P-WebArg-Storage-Models-Master-MasterPersons 'WebArg.Storage.Models.Master.MasterPersons')
  - [MasterStudios](#P-WebArg-Storage-Models-Master-MasterStudios 'WebArg.Storage.Models.Master.MasterStudios')
  - [Name](#P-WebArg-Storage-Models-Master-Name 'WebArg.Storage.Models.Master.Name')
  - [Qualification](#P-WebArg-Storage-Models-Master-Qualification 'WebArg.Storage.Models.Master.Qualification')
- [MasterPerson](#T-WebArg-Storage-Models-MasterPerson 'WebArg.Storage.Models.MasterPerson')
  - [IsnMaster](#P-WebArg-Storage-Models-MasterPerson-IsnMaster 'WebArg.Storage.Models.MasterPerson.IsnMaster')
  - [IsnPerson](#P-WebArg-Storage-Models-MasterPerson-IsnPerson 'WebArg.Storage.Models.MasterPerson.IsnPerson')
  - [Master](#P-WebArg-Storage-Models-MasterPerson-Master 'WebArg.Storage.Models.MasterPerson.Master')
  - [Person](#P-WebArg-Storage-Models-MasterPerson-Person 'WebArg.Storage.Models.MasterPerson.Person')
- [Person](#T-WebArg-Storage-Models-Person 'WebArg.Storage.Models.Person')
  - [IsnNode](#P-WebArg-Storage-Models-Person-IsnNode 'WebArg.Storage.Models.Person.IsnNode')
  - [IsnStudio](#P-WebArg-Storage-Models-Person-IsnStudio 'WebArg.Storage.Models.Person.IsnStudio')
  - [LastVisit](#P-WebArg-Storage-Models-Person-LastVisit 'WebArg.Storage.Models.Person.LastVisit')
  - [Name](#P-WebArg-Storage-Models-Person-Name 'WebArg.Storage.Models.Person.Name')
  - [PersonMasters](#P-WebArg-Storage-Models-Person-PersonMasters 'WebArg.Storage.Models.Person.PersonMasters')
  - [Studio](#P-WebArg-Storage-Models-Person-Studio 'WebArg.Storage.Models.Person.Studio')
- [Studio](#T-WebArg-Storage-Models-Studio 'WebArg.Storage.Models.Studio')
  - [IsnNode](#P-WebArg-Storage-Models-Studio-IsnNode 'WebArg.Storage.Models.Studio.IsnNode')
  - [Location](#P-WebArg-Storage-Models-Studio-Location 'WebArg.Storage.Models.Studio.Location')
  - [Name](#P-WebArg-Storage-Models-Studio-Name 'WebArg.Storage.Models.Studio.Name')
  - [Persons](#P-WebArg-Storage-Models-Studio-Persons 'WebArg.Storage.Models.Studio.Persons')
  - [StudioMasters](#P-WebArg-Storage-Models-Studio-StudioMasters 'WebArg.Storage.Models.Studio.StudioMasters')
- [StudioMaster](#T-WebArg-Storage-Models-StudioMaster 'WebArg.Storage.Models.StudioMaster')
  - [IsnMaster](#P-WebArg-Storage-Models-StudioMaster-IsnMaster 'WebArg.Storage.Models.StudioMaster.IsnMaster')
  - [IsnStudio](#P-WebArg-Storage-Models-StudioMaster-IsnStudio 'WebArg.Storage.Models.StudioMaster.IsnStudio')
  - [Master](#P-WebArg-Storage-Models-StudioMaster-Master 'WebArg.Storage.Models.StudioMaster.Master')
  - [Studio](#P-WebArg-Storage-Models-StudioMaster-Studio 'WebArg.Storage.Models.StudioMaster.Studio')

<a name='T-WebArg-Storage-Database-DataContext'></a>
## DataContext `type`

##### Namespace

WebArg.Storage.Database

##### Summary

Контекст базы данных

<a name='P-WebArg-Storage-Database-DataContext-Masters'></a>
### Masters `property`

##### Summary

Мастера

<a name='P-WebArg-Storage-Database-DataContext-MastersPersons'></a>
### MastersPersons `property`

##### Summary

Связь мастеров с клиентами

<a name='P-WebArg-Storage-Database-DataContext-Persons'></a>
### Persons `property`

##### Summary

Клиенты

<a name='P-WebArg-Storage-Database-DataContext-Studios'></a>
### Studios `property`

##### Summary

Студии

<a name='P-WebArg-Storage-Database-DataContext-StudiosMasters'></a>
### StudiosMasters `property`

##### Summary

Связь студии с мастерами

<a name='T-WebArg-Storage-Models-Master'></a>
## Master `type`

##### Namespace

WebArg.Storage.Models

##### Summary

Мастер

<a name='P-WebArg-Storage-Models-Master-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Storage-Models-Master-MasterPersons'></a>
### MasterPersons `property`

##### Summary

Связь мастера с клиентами

<a name='P-WebArg-Storage-Models-Master-MasterStudios'></a>
### MasterStudios `property`

##### Summary

Связь мастера со студиями

<a name='P-WebArg-Storage-Models-Master-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Storage-Models-Master-Qualification'></a>
### Qualification `property`

##### Summary

Квалификация

<a name='T-WebArg-Storage-Models-MasterPerson'></a>
## MasterPerson `type`

##### Namespace

WebArg.Storage.Models

##### Summary

Связь мастеров с клиентами

<a name='P-WebArg-Storage-Models-MasterPerson-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Storage-Models-MasterPerson-IsnPerson'></a>
### IsnPerson `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Storage-Models-MasterPerson-Master'></a>
### Master `property`

##### Summary

Мастер

<a name='P-WebArg-Storage-Models-MasterPerson-Person'></a>
### Person `property`

##### Summary

Клиент

<a name='T-WebArg-Storage-Models-Person'></a>
## Person `type`

##### Namespace

WebArg.Storage.Models

##### Summary

Клиент

<a name='P-WebArg-Storage-Models-Person-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор клиента

<a name='P-WebArg-Storage-Models-Person-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Storage-Models-Person-LastVisit'></a>
### LastVisit `property`

##### Summary

Последний визит

<a name='P-WebArg-Storage-Models-Person-Name'></a>
### Name `property`

##### Summary

ФИО

<a name='P-WebArg-Storage-Models-Person-PersonMasters'></a>
### PersonMasters `property`

##### Summary

Связь клиента с мастерами

<a name='P-WebArg-Storage-Models-Person-Studio'></a>
### Studio `property`

##### Summary

Студия

<a name='T-WebArg-Storage-Models-Studio'></a>
## Studio `type`

##### Namespace

WebArg.Storage.Models

##### Summary

Студия

<a name='P-WebArg-Storage-Models-Studio-IsnNode'></a>
### IsnNode `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Storage-Models-Studio-Location'></a>
### Location `property`

##### Summary

Местоположение

<a name='P-WebArg-Storage-Models-Studio-Name'></a>
### Name `property`

##### Summary

Наименование

<a name='P-WebArg-Storage-Models-Studio-Persons'></a>
### Persons `property`

##### Summary

Клиенты

<a name='P-WebArg-Storage-Models-Studio-StudioMasters'></a>
### StudioMasters `property`

##### Summary

Связь студии с мастерами

<a name='T-WebArg-Storage-Models-StudioMaster'></a>
## StudioMaster `type`

##### Namespace

WebArg.Storage.Models

##### Summary

Связь студии с мастерами

<a name='P-WebArg-Storage-Models-StudioMaster-IsnMaster'></a>
### IsnMaster `property`

##### Summary

Идентификатор мастера

<a name='P-WebArg-Storage-Models-StudioMaster-IsnStudio'></a>
### IsnStudio `property`

##### Summary

Идентификатор студии

<a name='P-WebArg-Storage-Models-StudioMaster-Master'></a>
### Master `property`

##### Summary

Мастера

<a name='P-WebArg-Storage-Models-StudioMaster-Studio'></a>
### Studio `property`

##### Summary

Студии
