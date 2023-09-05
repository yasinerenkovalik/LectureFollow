using System.Linq.Expressions;
using Application.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository;

public class Repository<T>:IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly OracleContext _context;

    public Repository(OracleContext context)
    {
        _context = context;
    }

    public T Get(Expression<Func<T, bool>>? filter)
    {
        return _context.Set<T>().FirstOrDefault(filter);
    }

    public void Add(T entity)
    {
        
            var addetentity = _context.Entry(entity);
            addetentity.State = EntityState.Added;
            _context.SaveChanges(); 
            addetentity.State = EntityState.Detached;
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

    public void Delete(int id)
    {
        var entity = GetById(id);
        entity.Active = false;
        var updateEntity = _context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        _context.SaveChanges(); 
        updateEntity.State = EntityState.Detached;
    }

    public void HardDelete(int id)
    {
        var entity = GetById(id);
        var deleteentity = _context.Entry(entity);
        deleteentity.State = EntityState.Deleted;
        _context.SaveChanges();
        deleteentity.State = EntityState.Detached;
    }

    public void Update(T entity)
    {
        var updateEntity = _context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        _context.SaveChanges();
        updateEntity.State = EntityState.Detached;
        
    }
}