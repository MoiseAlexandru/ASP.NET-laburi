using Lab4.Services.DemoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _demoService;
        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [HttpGet]
        public IActionResult GetByTitle(string title)
        {
            var result = _demoService.GetDataMappedByTitle(title);
            return Ok(result);
        }
    }
}
