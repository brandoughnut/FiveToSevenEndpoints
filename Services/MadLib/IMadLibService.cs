namespace FiveToSevenEndpoints.Services.MadLib;

    public interface IMadLibService
    {
        string MadLib(string nameInput1, string nameInput2, string locationInput, string timeInput, string restaurantInput, string verbInput, string numberInput, string toolInput, string animalInput, string colorInput);
    }
