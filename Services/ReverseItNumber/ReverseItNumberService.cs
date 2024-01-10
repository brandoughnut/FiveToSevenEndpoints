namespace FiveToSevenEndpoints.Services.ReverseItNumber;

public class ReverseItNumberService : IReverseItNumberService
{
    public string ReverseItNumber(string numberInput)
    {
        bool isTrue = double.TryParse(numberInput, out double num1);
        if (isTrue)
        {
            string stringNum = num1.ToString();
            string reverseIt = "";
            for(int i = stringNum.Length-1; i>=0; i--){
                reverseIt += stringNum[i];
            }
            double newDouble = Convert.ToDouble(reverseIt);
            return $"The reverse of {num1} is {newDouble}.";
        }
        else
        {
            return "That input was not valid.";
        }
    }
}
