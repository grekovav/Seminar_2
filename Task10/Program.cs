// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5  782 -> 8  918 -> 1

Console.Clear();

int ShowSecondDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int digit2 = (number - (digit1 * 100) - digit3) /10;
    return digit2;
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 || number > 999)
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}
else
{
    int numberSecond = ShowSecondDigit(number);
    Console.WriteLine($"В числе {number} вторая цифра {numberSecond}");
}
