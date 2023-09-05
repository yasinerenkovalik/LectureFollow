using System.Linq.Expressions;
using Domain;

namespace Application.Repository;

public interface IGenericRepository<T> where T:BaseEntity
{
    T Get(Expression<Func<T, bool>>? filter = null);
    void Add(T entity);
    List<T> GetAll(Expression<Func<T, bool>>? filter = null);
    T GetById(int id);
    void Delete(int id);
    void HardDelete(int id);
    void Update(T entity);
}