int ConvertToTwoDigit (int Number)
{
    if (Number<100)
    {
        if (Number<10)
        {
            Console.WriteLine ("Ошибка!!! Число однозначное!!!");
        }
        return Number;
    }
    else
    {
        while (Number/100!=0)
        {
            Number = Number/10;
        }
        return Number;
    }
      
}

void ReturnSecondDigit (string? EnteredNumber)
{
    bool NumberOrText = Int32.TryParse(EnteredNumber, out int Number);
    if (NumberOrText)
    {
        Number=ConvertToTwoDigit(Number);
        if (Number>10)
        {
            Number = Number%10;
            Console.WriteLine($"Вторая цифра введенного числа {Number}.");
        }
    }
    else
    {
        Console.WriteLine ("ОШИБКА!!! Введены некорректные данные. Пожалуйста, введите число");
    }    
}

Console.Clear();
Console.WriteLine("Пожалуйста, введите число");
string? EnteredNumber = Console.ReadLine();
ReturnSecondDigit (EnteredNumber);