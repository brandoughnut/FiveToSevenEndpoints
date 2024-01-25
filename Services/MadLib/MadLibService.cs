namespace FiveToSevenEndpoints.Services.MadLib;

public class MadLibService : IMadLibService
{
    
    public string MadLib(string nameInput1, string nameInput2, string locationInput, string timeInput, string restaurantInput, string verbInput, string numberInput, string toolInput, string animalInput, string colorInput)
    {
        return $"{nameInput1} and {nameInput2} were on their way to to eat at {restaurantInput}. When they went to pay, they decided to split the bill into {numberInput} separate payment(s). After they finished eating, {nameInput1} suggested to go sightseeing at {locationInput}. They arrived to {locationInput} at {timeInput}, but while they were walking around, they suddenly encounterd a(n) {animalInput}. {nameInput2} luckily had a(n) {colorInput} {toolInput} on hand, while {nameInput1} decided to {verbInput}. Fortunately, the {animalInput} ran away in fear, and they both decided to never go to {locationInput} at {timeInput} ever again.";
    }

}
