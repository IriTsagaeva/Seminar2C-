void ShowHoliday (int DayNumber)
{
    if ((DayNumber>0)&&(DayNumber<6))
        {
            Console.WriteLine($"День недели под номером {DayNumber} не выходной");
        }
    else if ((DayNumber==6)||(DayNumber==7))
       {
           Console.WriteLine($"День недели под номером {DayNumber} выходной");
       }
    else
       {
       Console.WriteLine($"День недели под номером {DayNumber} не существует");
       }
}

Console.Clear();
Console.WriteLine("Пожалуйста, введите день недели");
bool text = Int32.TryParse(Console.ReadLine(), out int WeekDay);
if (text)
    {
        ShowHoliday(WeekDay);
    }
else
    {
        Console.WriteLine($"Пожалуйста, введите число!!");
    }