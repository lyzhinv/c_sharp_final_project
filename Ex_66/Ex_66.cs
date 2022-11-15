// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {m}; N = {n} -> {GetSumNumbers(m, n)}");

int GetSumNumbers(int number1, int number2)
{
    if (number1 == number2) return number1;
    return number1 + GetSumNumbers(number1 + 1, number2);
}
