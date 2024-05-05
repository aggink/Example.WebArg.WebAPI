<a name='assembly'></a>
# WebArg.Storage.MS_SQL

## Contents

- [InitDatabase](#T-WebArg-Storage-MS_SQL-Migrations-InitDatabase 'WebArg.Storage.MS_SQL.Migrations.InitDatabase')
  - [BuildTargetModel()](#M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder- 'WebArg.Storage.MS_SQL.Migrations.InitDatabase.BuildTargetModel(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [Down()](#M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.Storage.MS_SQL.Migrations.InitDatabase.Down(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
  - [Up()](#M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.Storage.MS_SQL.Migrations.InitDatabase.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
- [MigrationService](#T-WebArg-Storage-MS_SQL-Services-MigrationService 'WebArg.Storage.MS_SQL.Services.MigrationService')
  - [ApplyMigrations()](#M-WebArg-Storage-MS_SQL-Services-MigrationService-ApplyMigrations 'WebArg.Storage.MS_SQL.Services.MigrationService.ApplyMigrations')
- [SqlServerContextFactory](#T-WebArg-Storage-MS_SQL-SqlServerContextFactory 'WebArg.Storage.MS_SQL.SqlServerContextFactory')

<a name='T-WebArg-Storage-MS_SQL-Migrations-InitDatabase'></a>
## InitDatabase `type`

##### Namespace

WebArg.Storage.MS_SQL.Migrations

##### Summary

*Inherit from parent.*

<a name='M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### BuildTargetModel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Down() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-Storage-MS_SQL-Migrations-InitDatabase-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Up() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WebArg-Storage-MS_SQL-Services-MigrationService'></a>
## MigrationService `type`

##### Namespace

WebArg.Storage.MS_SQL.Services

##### Summary

Взаимодействие с базой данных

<a name='M-WebArg-Storage-MS_SQL-Services-MigrationService-ApplyMigrations'></a>
### ApplyMigrations() `method`

##### Summary

Применение миграций

##### Returns

True - миграции применены успешно

##### Parameters

This method has no parameters.

<a name='T-WebArg-Storage-MS_SQL-SqlServerContextFactory'></a>
## SqlServerContextFactory `type`

##### Namespace

WebArg.Storage.MS_SQL

##### Summary

Фабрика для создания производных [DataContext](#T-WebArg-Storage-Database-DataContext 'WebArg.Storage.Database.DataContext') экземпляров
