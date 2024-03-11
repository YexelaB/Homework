// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// В псевдокоде функция Аккермана реализуется по определению:
// функция ack(n, m)
// если n = 0
// вернуть m + 1
// иначе, если m = 0
// вернуть ack (n - 1, 1)
// еще
// вернуть ack(n - 1, ack (n, m - 1))

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

int m = 1, n = 2;
Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");