using Microsoft.AspNetCore.Mvc;
using SolidTask.Services.Herbavore;
using SolidTask.Services.Herbavore.Add;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class HerbavoreController : ControllerBase
{
    private readonly IHerbavoreService _herbavoreService;

    public HerbavoreController(IHerbavoreService herbavoreService)
    {
        _herbavoreService = herbavoreService;
    }

    [HttpGet]
    public IActionResult All()
    {
        var result = _herbavoreService.All();
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Add([FromBody] HerbavoreRequest request)
    {
        _herbavoreService.Add(request);
        return Ok();
    }

}

