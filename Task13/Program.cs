// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5  78 -> третьей цифры нет  32679 -> 6

Console.Clear();

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99)
{
    int Third = (number / 100) % 10;
    Console.WriteLine($"Третья цифра: {Third}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
