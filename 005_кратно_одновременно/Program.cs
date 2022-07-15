int inputValue = Convert.ToInt32(Console.WriteLine());
bool IsMultiplicity (int namber)
{
    return(namber %7 == 0 && namber % 23 == 0);
}
Console.WriteLine(IsMultiplicity(inputValue));