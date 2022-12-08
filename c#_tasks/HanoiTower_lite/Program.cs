int countStep = 0; 
void Step(int n, string a, string b, string c)
{
    if (n > 0) 
    {
    Step(n - 1, a, c, b);
    countStep ++;
    Console.WriteLine($"Ход {countStep}");
    Console.WriteLine($"Перенеси диск с {a} стержня на {b} стержень");
    Console.WriteLine("Жми ENTER");
    Console.ReadKey();
    Step(n - 1, c, b, a);
    }
}
Console.Clear();
Console.WriteLine("Введите кол-во дисков:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ханойская башня состоит из {num} дисков");
Console.WriteLine();
Step(num, "I", "II", "III");
Console.WriteLine($"Все диски перенесены за {countStep} шагов");