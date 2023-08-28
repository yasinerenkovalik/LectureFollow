using System.Linq.Expressions;
using Domain;

namespace Application.Repository;

public interface IGenericRepository<T> where T:IEntity
{
    bool Add(T entity);
    List<T> GetAll(Expression<Func<T, bool>>? filter = null);
    T GetById(int id);
    bool Delete(int id);
    bool HardDelete(int id);
    bool Update(T entity);
}