// Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void PrintArrayReversed(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write($"{array[index]} ");
    PrintArrayReversed(array, index - 1);
}

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReversed(array, array.Length - 1);
