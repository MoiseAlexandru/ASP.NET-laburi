using Lab4.Models.DTOs;

namespace Lab4.Services.DemoService
{
    public interface IDemoService
    {
        ModelResultDTO GetDataMappedByTitle(string title);
    }
}
