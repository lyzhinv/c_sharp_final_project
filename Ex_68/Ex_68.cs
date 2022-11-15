// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите (положительное) число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите (положительное) число N");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0) Console.WriteLine("Ошибка! Числа M и N не могут быть отрицательными");
else Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {GetAckermannFunction(m, n)}");

int GetAckermannFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number1 > 0 && number2 == 0) return GetAckermannFunction(number1 - 1, 1);
    if (number1 > 0 && number2 > 0) return GetAckermannFunction(number1 - 1, GetAckermannFunction(number1, number2 - 1));
    return number1;
}
