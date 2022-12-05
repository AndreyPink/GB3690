Console.WriteLine("Введите кол-во чисел:");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    int elem = int.Parse(Console.ReadLine()!);
    array[i] = elem;
}
int arrayMin = array.Min();
for (int dev = arrayMin; dev > 0; dev--)
{
    bool check = true;
    for (int j = 0; j < number; j++)
    {
        if (array[j] % dev != 0)
        {
            check = false;
        }
    }
    if(check == true)
    {
        Console.WriteLine($"Максимальный делитель всех чисел равен {dev}");
        break;
    }
}
