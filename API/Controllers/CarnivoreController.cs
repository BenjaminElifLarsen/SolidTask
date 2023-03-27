using Microsoft.AspNetCore.Mvc;
using SolidTask.Services.Carnivore;
using SolidTask.Services.Carnivore.Add;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class CarnivoreController : ControllerBase
{
    private readonly ICarnivoreService _carnivoreService;

    public CarnivoreController(ICarnivoreService carnivoreService)
    {
        _carnivoreService = carnivoreService;
    }

    [HttpGet]
    public IActionResult All()
    {
        var result = _carnivoreService.All();
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Add([FromBody] CarnivoreRequest request)
    {
        _carnivoreService.Add(request);
        return Ok();
    }
}
