// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//поскольку в условии не указано иное, 
//код позволяет проверять в том числе отрицательные числа


//РЕШЕНИЕ ЧЕРЕЗ ЦИКЛ И MATH.POW

Console.WriteLine("Введите скольки-хочешь-значное число");
int num = Math.Abs(int.Parse(Console.ReadLine()!)); //Math.Abs - определяет модуль числа
string numString = num.ToString(); //ToString - преобразует число в строку с символами
if (numString.Length >= 3) //определяем что длина строка не меньше 3
{
    Console.WriteLine($"Третья цифра = {numString[2]}"); //обращаясь через индекс [2] берем 3-й символ строки
}
else
{
    Console.WriteLine("третьей цифры нет");
}

