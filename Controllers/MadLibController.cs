using FiveToSevenEndpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MadLibController : Controller
    {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
        {
        _madLibService = madLibService;
    }
        [HttpGet]
        [Route("MadLib/{nameInput1}/{nameInput2}/{locationInput}/{timeInput}/{restaurantInput}/{verbInput}/{numberInput}/{toolInput}/{animalInput}/{colorInput}")]
        public string MadLib(string nameInput1, string nameInput2, string locationInput, string timeInput, string restaurantInput, string verbInput, string numberInput, string toolInput, string animalInput, string colorInput)
    {
        return _madLibService.MadLib(nameInput1, nameInput2, locationInput, timeInput, restaurantInput, verbInput, numberInput, toolInput, animalInput, colorInput);
    }
    }
