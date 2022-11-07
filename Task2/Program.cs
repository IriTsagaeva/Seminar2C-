int ConvertToThreeDigit (int Number)
{
    if (Number<100)
    {
        Console.WriteLine ("Третьей цифры нет");
        return Number;
    }
    else
    {
        while (Number/1000!=0)
        {
            Number = Number/10;
        }
        return Number;
    }
      
}

void ReturnThirdDigit (string? EnteredNumber)
{
    bool NumberOrText = Int32.TryParse(EnteredNumber, out int Number);
    if (NumberOrText)
    {
        Number=ConvertToThreeDigit(Number);
        if (Number>=100)
        {
            Number = Number%10;
            Console.WriteLine($"Третья цифра введенного числа {Number}.");
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
ReturnThirdDigit(EnteredNumber); 