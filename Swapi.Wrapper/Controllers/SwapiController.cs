using Microsoft.AspNetCore.Mvc;
using Refit;
using Swapi.Schema;
using Swapi.Wrapper.Services;

namespace Swapi.Wrapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        private readonly ISwapi _swapiService;

        public SwapiController()
        {
            _swapiService = RestService.For<ISwapi>("https://swapi.dev/api/"); ;
        }

        [HttpGet]
        public async Task<Person> Get(int id)
        {
            return await _swapiService.GetPerson(id);
        }
    }
}
