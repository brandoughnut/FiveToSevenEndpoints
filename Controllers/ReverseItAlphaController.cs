using FiveToSevenEndpoints.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphaController : Controller
    {
    private readonly IReverseItAlphaService _reverseItAlphaService;

    public ReverseItAlphaController(IReverseItAlphaService reverseItAlphaService)
        {
        _reverseItAlphaService = reverseItAlphaService;
    }
        [HttpGet]
        [Route("ReverseItAlpha/{stringInput}")]
        public string ReverseItAlpha(string stringInput)
        {
            return _reverseItAlphaService.ReverseItAlpha(stringInput);
        }
    }
