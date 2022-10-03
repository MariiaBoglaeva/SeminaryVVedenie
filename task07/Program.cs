// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number<=999)
{
int lastDigit = number%10;
Console.Write($"Последняя цифра числа {lastDigit}");
}
else Console.Write("Число не трехзначное");