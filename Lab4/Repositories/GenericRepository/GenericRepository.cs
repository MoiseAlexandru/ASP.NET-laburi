using Lab4.Data;
using Lab4.Models.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Lab4Context _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(Lab4Context context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }


        // .AsNoTracking() => bun cand stiu ca nu trebuie sa fac modificari asupra datelor
        // Get all
        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public IQueryable <TEntity> GetAllAsQueryable()
        {
            return _table.AsNoTracking();
        }
            
        // Create
        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        // Update
        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        // Delete
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        // Find
        public TEntity FindById(object id)
        {
            return _table.Find(id);
            // sau return _table.FirstOrDefault(x => x.Id.Equals(id)) - mai lent, nu verifica existenta lui
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
            // sau return await _table.FirstOrDefaultAsync(x => x.Id.Equals(id))
        }

        // Save
        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
