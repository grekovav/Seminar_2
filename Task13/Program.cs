// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5  78 -> третьей цифры нет  32679 -> 6

Console.Clear();

int FindThirdDigit(int num)
{
	int result;
	if(num > 99)
   {
		int ed = num % 10;
    }
	result = ed;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = FindThirdDigit(number);
Console.WriteLine($"Third Digit of {number} is {thirdDigit}");

int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();