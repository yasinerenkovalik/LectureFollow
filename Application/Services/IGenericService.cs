using System.Linq.Expressions;
using Domain;

namespace Application.Services;

public interface IGenericService<T> where T :BaseEntity
{
    bool Add(T entity);
    List<T> GetAll();
    T GetById(int id);
    bool Delete(int id);
    bool HardDelete(int id);
    bool Update(T entity);
    T Get();
}