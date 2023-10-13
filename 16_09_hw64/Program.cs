/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Input(string massege)
{
    Console.Write(massege);
    return int.Parse(Console.ReadLine()!);
}

int AkkermanFunk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunk(m - 1, 1);
    else return AkkermanFunk(m - 1,AkkermanFunk(m, n -1)); 
}

int m = Input("Введите 1 число: ");
int n = Input("Введите 2 число: ");
Console.Write($"Результат функции Аккермана: {AkkermanFunk(m, n)}");