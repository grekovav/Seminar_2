// 14. Напишите программу, которая принимает на вход число и определяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);
if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно числам 7 и 23.");
}
else
{
    Console.WriteLine($"Число {number} не кратно числам 7 и 23.");
}
