using Application.Services;
using Domain;

namespace Persistence.Service;

public class Services<T>:IGenericService<T> where T :BaseEntity
{
    private readonly IGenericService<T> _genericService;

    public Services(IGenericService<T> genericService)
    {
        _genericService = genericService;
    }
    public bool Add(T entity)
    {
        var result = _genericService.Add(entity);
        if (result)
        {
            return true;
        }

        return false;
    }

    public List<T> GetAll()
    {
        var result = _genericService.GetAll();
     
        return result;
    }

    public T GetById(int id)
    {
        var result = _genericService.GetById(id);
        return result;
    }

    public bool Delete(int id)
    {
        var result = _genericService.Delete(id);
        if (result)
        {
            return true;
        }

        return false;
    }

    public bool HardDelete(int id)
    {
        var result = _genericService.HardDelete(id);
        if (result)
        {
            return true;
        }

        return false;
    }

    public bool Update(T entity)
    {
        var result = _genericService.Update(entity);
        if (result)
        {
            return true;
            
        }

        return false;
    }
}