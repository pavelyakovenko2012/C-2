int inputValue = Convert.ToInt32(Console.WriteLine());
bool IsMultiplicity(int number);
{
    return(number % 7 == 0 && number % 23 == 0);
}
Console.WriteLine(IsMultiplicity(inputValue));