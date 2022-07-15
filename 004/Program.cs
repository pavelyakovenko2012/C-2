int dayNamber = Convert.ToInt32(Console.ReadLine());
if (dayNamber>=1 && dayNamber <=7 )
{
    if (dayNamber == 1 )
    {
         Console.WriteLine("НЕТ-Понедельник");
    }
    if (dayNamber == 2 )
    {
         Console.WriteLine("НЕТ-Вторник");
    }
    if (dayNamber == 3 )
    {
         Console.WriteLine("НЕТ-Среда");
    }
    if (dayNamber == 4 )
    {
         Console.WriteLine("НЕТ-Четверг");
    }
    if (dayNamber == 5 )
    {
         Console.WriteLine("НЕТ-Пятница");
    }
    if (dayNamber == 6 )
    {
         Console.WriteLine("ДА-Суббота");
    }
    if (dayNamber == 7 )
    {
         Console.WriteLine("ДА-Воскресенье");
    }
}
else
{
     Console.WriteLine("Error 404, day not found");
}
