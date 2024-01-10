using FiveToSevenEndpoints.Services.ReverseItNumber;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumberController : Controller
    {
    private readonly IReverseItNumberService _reverseItNumberService;

    public ReverseItNumberController(IReverseItNumberService reverseItNumberService)
    {
        _reverseItNumberService = reverseItNumberService;
    }
    [HttpGet]
    [Route("ReverseItNumber/{numberInput}")]
    public string ReverseItNumber(string numberInput)
    {
        return _reverseItNumberService.ReverseItNumber(numberInput);
    }
    }
