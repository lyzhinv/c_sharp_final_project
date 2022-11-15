// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"N = {n} -> {GetNumbers(n, 1)}");

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + ", " + GetNumbers(start - 1, end);
}
