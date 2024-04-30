using WebArg.Storage.Database;

namespace WebArg.Logic.Interfaces.Repositories;

/// <summary>
/// CRUD методы с моделью
/// </summary>
/// <typeparam name="TModel">Тип модели</typeparam>
public interface IRepository<TModel>
        where TModel : class
{
    /// <summary>
    /// Получить запись
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnNode">Идентификатор записи</param>
    /// <returns>Запись</returns>
    Task<TModel> GetByIdAsync(DataContext dataContext, Guid isnNode);

    /// <summary>
    /// Добавить запись в базу данных
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="model">Модель</param>
    /// <returns>Запись добавленная в базу данных</returns>
    TModel Create(DataContext dataContext, TModel model);

    /// <summary>
    /// Обновить запись в базе данных
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="model">Модель</param>
    /// <returns>Обновленная запись в базе данных</returns>
    Task<TModel> UpdateAsync(DataContext dataContext, TModel model);

    /// <summary>
    /// Удалить запись из базу данных
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="isnNode">Идентификатор записи</param>
    /// <returns>Удаленная запись из базы данных</returns>
    Task<TModel> DeleteAsync(DataContext dataContext, Guid isnNode);
}
