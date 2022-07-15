bool IsMultiplicity(int number)
{
    return(number % 7 == 0 && number % 23 == 0);
}
System.Console.WriteLine(IsMultiplicity(161));