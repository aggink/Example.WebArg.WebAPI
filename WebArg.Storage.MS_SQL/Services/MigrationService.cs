﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebArg.Storage.Database;

namespace WebArg.Storage.MS_SQL.Services;

/// <summary>
/// Взаимодействие с базой данных
/// </summary>
public class MigrationService
{
    private readonly ILogger<MigrationService> _logger;
    private readonly IServiceProvider _serviceProvider;

    public MigrationService(
        ILogger<MigrationService> logger,
        IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Применение миграций
    /// </summary>
    /// <returns>True - миграции применены успешно</returns>
    public bool ApplyMigrations()
    {
        lock (typeof(MigrationService))
        {
            try
            {
                _logger.LogInformation("Применение миграций");

                using var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
                using var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();

                dbContext.Database.SetCommandTimeout(3600);
                _logger.LogInformation("Подключение: " + dbContext.Database.GetConnectionString());

                var IsExists = dbContext!.GetService<IDatabaseCreator>() is RelationalDatabaseCreator DbCreator && DbCreator.Exists();
                if (!IsExists)
                {
                    var migrations = dbContext.Database.GetPendingMigrations().ToArray();
                    if (migrations.Length == 0)
                        throw new Exception("Миграции не найдены (возможно не указана ссылка на сборку с миграциями)");

                    dbContext!.Database.Migrate();
                    dbContext!.SaveChanges();
                }

                _logger.LogWarning("База данных обновлена");

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Не удалось обновить базу данных");
            }

            return false;
        }
    }
}
