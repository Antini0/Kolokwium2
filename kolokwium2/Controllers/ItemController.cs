using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IdbService _dbService;

    public ItemController(IdbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet]
    public async Task<IActionResult> GetItemsById(int IdItem)
    {
        var result = await _dbService.GetItemById(IdItem);
        return Ok(result);
    }
}