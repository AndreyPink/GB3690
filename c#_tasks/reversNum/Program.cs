int a = 3;
int b = 5;
 
a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"Числа наоборот - {a}, {b}");
