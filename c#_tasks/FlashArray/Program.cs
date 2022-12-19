// Задача - Массив "Молния"
// Создайте два произвольных массива одинаковой длины (длину одного массива можете установить сами).
// Объедините их по принципу "молнии":
// Т.е. за первым элементом 1-го массива, должен идти 1-й элемент второго массива, 
// далее 2-й элемент первого массива, и 2-й элемент второго массива, и т.д.
// Выведите на экран все три массива: 2 исходных и 3-й объединенный по принципу "молнии".
// Код должен быть полностью "упакован" в методы.
// При написании кода используйте не более 2-х методов.




int[] CreateArray()
{
    Console.Write("Исходный массив {");
    int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("}\n");
    return array;
}

void Flash(int[] array1, int[] array2)
{
    Console.Write("Массив молния {");
    int[] flashArray = new int[array1.Length * 2];
    int j = 0;
    for (int i = 0; i < flashArray.Length; i++)
    {
        if (i % 2 == 0) flashArray[i] = array1[j];
        else
        {
            flashArray[i] = array2[j];
            j++;
        }
        Console.Write($"{flashArray[i]} ");
    }
    Console.WriteLine("}");
}
Flash(CreateArray(), CreateArray());
