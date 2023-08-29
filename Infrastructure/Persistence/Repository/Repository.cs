using System.Linq.Expressions;
using Application.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository;

public class Repository<T>:IGenericRepository<T> where T :class,IEntity,new()
{
    private readonly OracleContext _context;

    public Repository(OracleContext context)
    {
        _context = context;
    }
    public bool Add(T entity)
    {
        var addetentity = _context.Entry(entity);
        addetentity.State = EntityState.Added;
        _context.SaveChanges();
        if (addetentity.State == EntityState.Added)
        {
            addetentity.State = EntityState.Detached;
            return true;
        }
        return false;
    }

    public List<T> GetAll(Expression<Func<T, bool>>? filter = null)
    {
        return filter == null ? _context.Set<T>().ToList() :
            _context.Set<T>().Where(filter).ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().FirstOrDefault(n => n.Id == id);
    }

    public bool Delete(int id)
    {
        var entity = GetById(id);
        entity.Active = false;
        var updateEntity = _context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        _context.SaveChanges();
        if (updateEntity.State == EntityState.Modified)
        {
            updateEntity.State = EntityState.Detached;
            return true;
        }
        return false;
    }

    public bool HardDelete(int id)
    {
        var entity = GetById(id);
        var deleteentity = _context.Entry(entity);
        deleteentity.State = EntityState.Deleted;
        _context.SaveChanges();
        if (deleteentity.State == EntityState.Deleted)
        {
            deleteentity.State = EntityState.Detached;
            return true;
        }
        
        return false;
    }

    public bool Update(T entity)
    {
        var updateEntity = _context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        _context.SaveChanges();
        updateEntity.State = EntityState.Detached;
        if (updateEntity.State == EntityState.Modified)
        {
            updateEntity.State = EntityState.Detached;
            return true;
        }
        return false;
    }
}