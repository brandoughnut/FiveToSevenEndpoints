namespace FiveToSevenEndpoints.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string numberInput)
    {
        bool isTrue = int.TryParse(numberInput, out int num1);

        if (isTrue)
        {
            if (num1 % 2 == 0)
            {
                return $"{num1} is an even number.";
            }
            else
            {
                return $"{num1} is an odd number.";
            }
        }
        else
        {
            return "That input was not valid.";
        }
    }
}
