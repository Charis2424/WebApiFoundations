using Database;
using RepoInterfaces;


namespace Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _dbContext;
        public RepositoryManager(AppDbContext dbContext)
        {  
            _dbContext = dbContext; 
        }
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
