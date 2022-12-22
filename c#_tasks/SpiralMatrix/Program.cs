// Задача 60: Заполните спирально массив 4 на 4.

// !!РАЗОБРАТЬСЯ КАК РАБОТАЕТ ЭТОТ МЕТОД!!

int[,] Spiral(int n)
{
    int[,] result = new int[n, n];

    int pos = 1;
    int count = n;
    int value = -n;
    int sum = -1;

    do
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

    return result;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine("Заполненный массив:");
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]}\t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine();
}

PrintArray(Spiral(5));
