using Lab4.Data;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Repositories.DatabaseRepository
{
    public class DatabaseRepository : GenericRepository.GenericRepository<Model1>, IDatabaseRepository
    {
        public DatabaseRepository(Lab4Context context) : base(context)
        {

        }
        public List<Model1> GetAllWithInclude()
        {
            return _table.Include(x => x.Models2).ToList();
        }

        public List<Model1> GetAllWithJoin()
        {
            var result = _table.Join(_context.Models2, model1 => model1.Id, model2 => model2.Model1Id, (model1, model2) => new { model1, model2 }).Select(obj => obj.model1);
            return result.ToList();
        }
        public Model1 GetByTitle(string title)
        {
            return _table.FirstOrDefault(x => x.Title.ToLower().Equals(title.ToLower()));
        }
    }
}
