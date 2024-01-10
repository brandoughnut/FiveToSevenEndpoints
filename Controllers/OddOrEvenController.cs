using FiveToSevenEndpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : Controller
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }
    [HttpGet]
    [Route("OddOrEven/{numberInput}")]
    public string OddOrEven(string numberInput)
    {
        return _oddOrEvenService.OddOrEven(numberInput);
    }
}
