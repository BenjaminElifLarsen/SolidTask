using Microsoft.AspNetCore.Mvc;
using SolidTask.Models;
using SolidTask.Services;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class HerbavoreController : ControllerBase
{
    private readonly IHerbavoreRepository _repository;
    private readonly IAnimalRepository _animalRepository;

    public HerbavoreController(IHerbavoreRepository repository, IAnimalRepository animalRepository)
    {
        _repository = repository;
        _animalRepository = animalRepository;
    }

    [HttpGet]
    public IActionResult All()
    {
        var result = _repository.All;
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Add([FromBody] HerbavoreRequest request)
    {
        _animalRepository.AddAnimal(new Herbavore(request.Name, request.IsBird));
        return Ok();
    }

    public class HerbavoreRequest
    {
        public string Name { get; set; }
        public bool IsBird { get; set; }
    }
}
