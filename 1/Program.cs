// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNaturalNumbers(int M, int N)
{
    if (M > N) return;
    Console.Write($"{M} ");
    PrintNaturalNumbers(M + 1, N);
}

Console.WriteLine("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральные числа от M до N:");
PrintNaturalNumbers(M, N);

Console.ReadLine();

