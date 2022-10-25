using Refit;
using Swapi.Schema;

namespace Swapi.Wrapper.Services;

public interface ISwapi
{
    [Get("/people/{id}")]
    Task<Person> GetPerson(int id);
}
