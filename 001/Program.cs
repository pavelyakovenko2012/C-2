int namber = new Random().Next(10,100);
System.Console.WriteLine(namber);
int firstDigit = namber / 10;
int secondDigit = namber % 10;
System.Console.WriteLine(firstDigit);
System.Console.WriteLine(secondDigit);
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Первое число {firstDigit} больше");
}
else if
{
    Console.WriteLine($"Второе число {secondDigit} больше");
}
else
{
    Console.WriteLine($"Равны");
}

