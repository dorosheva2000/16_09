/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Input(string massege)
{
    Console.Write(massege);
    return int.Parse(Console.ReadLine()!);
}

int SumInRange(int m, int n)
{
    if (m == n) return n;
    return n + SumInRange(m, --n);
}

int m = Input("Введите 1 число: ");
int n = Input("Введите 2 число: ");
Console.Write(@$"Сумма чисел: {SumInRange(m, n)}");