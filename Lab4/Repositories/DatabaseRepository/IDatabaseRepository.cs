using Lab4.Models;
using Lab4.Repositories.GenericRepository;

namespace Lab4.Repositories.DatabaseRepository
{
    public interface IDatabaseRepository : IGenericRepository <Model1>
    {
        List<Model1> GetAllWithInclude();
        List<Model2> GetAllWithJoin();
        Model1 GetByTitle(string title);
    }
}
