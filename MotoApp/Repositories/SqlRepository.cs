using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;

namespace MotoApp.Repositories;

public class SqlRepository
{
    private readonly DbSet<Employee> _dbset;
    private readonly DbContext _dbContext;

    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbset = dbContext.Set<Employee>();
    }

    public Employee? GetById(int id) => _dbset.Find(id);

    public void Add(Employee item) => _dbset.Add(item);

    public void Remove(Employee item) => _dbset.Remove(item);

    public void Save() => _dbContext.SaveChanges();
}
