using Microsoft.EntityFrameworkCore;
using QuickSale.DAL.Interfaces;

namespace QuickSale.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T? GetById(int id) => _dbSet.Find(id);

    public void Add(T entity) => _dbSet.Add(entity);

    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity is not null)
            _dbSet.Remove(entity);
    }

    public void Save() => _context.SaveChanges();
}
