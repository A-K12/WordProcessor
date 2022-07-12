namespace WordProcessor.Сore.Models;

public interface IRepository<TEntity>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void DeleteAll();
    List<TEntity> GetAll();
    void Save();

}