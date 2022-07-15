int firstNumber = Convert.ToInt32(System.Console.WriteLine());
int secondNumber = Convert.ToInt32(System.Console.WriteLine());
if(firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("КРАТНО");
}
else
{
    System.Console.WriteLine($"ОСТАТОК: {firstNumber % secondNumber}");
}