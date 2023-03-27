using Microsoft.AspNetCore.Mvc;
using SolidTask.Models;
using SolidTask.Services;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class CarnivoreController : ControllerBase
{
    private readonly ICarnivoreRepository _repository;
    private readonly IAnimalRepository _animalRepository;

    public CarnivoreController(ICarnivoreRepository carnivoreRepository, IAnimalRepository animalRepository)
    {
        _repository = carnivoreRepository;
        _animalRepository = animalRepository;
    }

    [HttpGet]
    public IActionResult All()
    { //non-lean endpoints
        var result = _repository.All;
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Add([FromBody] CarnivoreRequest request)
    {
        _animalRepository.AddAnimal(new Carnivore(request.Name, request.IsBird));
        return Ok();
    }

    public class CarnivoreRequest
    {
        public string Name { get; set; }
        public bool IsBird { get; set; }
    }
}
