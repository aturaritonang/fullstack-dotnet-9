namespace ECommerce.WebApp.Repositories;

public interface IRepository<S, T>
{
    List<T> GetAll();
    T Get(int id);
    List<T> GetByParent(int? id);
    T Create(S dto);
    T Update(S dto);
    bool Delete(int id);
}
