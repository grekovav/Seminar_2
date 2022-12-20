// 12. Напишите программу, которая определяет, кратно ли одно число другому.
// Если не кратно, то вывести остаток.
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 % number2 == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}.");
}
else
{
    int ostatok = number1 % number2;
    Console.WriteLine($"Число {number2} не кратно числу {number1}. Остаток {ostatok}.");
}
