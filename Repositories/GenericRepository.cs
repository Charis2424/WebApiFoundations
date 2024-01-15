using Database;
using RepoInterfaces;
using System.Linq.Expressions;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _context;
        public GenericRepository(AppDbContext appDbContext)
        => _context = appDbContext;

        public IQueryable<T> FindAll() => _context.Set<T>();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => _context.Set<T>().Where(expression);
        public async void Create(T entity) => await _context.Set<T>().AddAsync(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
