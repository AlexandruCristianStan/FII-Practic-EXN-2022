using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExnCars.Data
{
  public class Repository<T> : IRepository<T>
    where T : class
  {
    private readonly DbSet<T> dbSet;
    private readonly DbContext dbContext; 

    public Repository(DbContext dbContext)
    {
      this.dbContext = dbContext;
      this.dbSet = dbContext.Set<T>();
    }

    public void Add(T entity)
    {
      dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
      dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
      dbSet.Attach(entity);
      dbContext.Entry(entity).State = EntityState.Modified;
    }

    public T? GetById(int id)
    {
      return dbSet.Find(id);
    }

    public IQueryable<T> Query(Expression<Func<T, bool>> expression)
    {
      return dbSet.Where(expression);
    }
  }
}
