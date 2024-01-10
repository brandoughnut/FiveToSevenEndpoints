namespace FiveToSevenEndpoints.Services.ReverseItAlpha;

public class ReverseItAlphaService : IReverseItAlphaService
{
    public string ReverseItAlpha(string stringInput)
    {
        string reverseIt = "";
        for (int i = stringInput.Length - 1; i >= 0; i--)
        {
            reverseIt += stringInput[i];
        }
        return $"The reverse of {stringInput} is {reverseIt}.";
    }
}
