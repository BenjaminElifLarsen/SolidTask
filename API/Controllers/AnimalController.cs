using Microsoft.AspNetCore.Mvc;
using SolidTask.Services.Animal;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult All()
    {
        return Ok(_animalService.All());
    }
}
