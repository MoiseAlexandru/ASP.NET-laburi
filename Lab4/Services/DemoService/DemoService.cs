using Lab4.Models;
using Lab4.Models.DTOs;
using Lab4.Repositories.DatabaseRepository;

namespace Lab4.Services.DemoService
{
    public class DemoService : IDemoService
    {
        public IDatabaseRepository _databaseRepository;
        public DemoService(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }
        public ModelResultDTO GetDataMappedByTitle(string title)
        {
            Model1 model1 = _databaseRepository.GetByTitle(title);
            ModelResultDTO result = new()
            {
                Title = model1.Title,
                Order = model1.Order
            };
            return result;
        }
    }
}
