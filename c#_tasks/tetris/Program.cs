
using System;

string[,] array = {{"1","2","3"}, {"4","5","6"}, {"7","8","9"}};

bool win = false;
int line = 0;
int column = 0;
 
void Instruction()
{
Console.Clear();
Console.WriteLine("Привет дорогой друг и будущий соперник ;-)");
Console.WriteLine("мы начинаем играть в крестики-нолики.");
Console.WriteLine("Ходим по очереди, первый играет Крестиками, второй Ноликами.");
Console.WriteLine("После нажатия Enter/Return начнется игра");
Console.WriteLine("и тебе нужно будет выбрать клетку в которую ты сделаешь ход.");
Console.WriteLine();
Console.WriteLine("Так как наша доска имеет размерность 3x3,");
Console.WriteLine("то и каждая клетка имеет номер, состоящий из двух символов.");
Console.WriteLine("Их тебе нужно будет набрать поочереди, между ними нажимая Enter/Return");
Console.WriteLine("Номера клеток подписаны на доске.");
Console.WriteLine();
Console.WriteLine("Ну что же, начнем!");
Console.WriteLine("ДЛЯ НАЧАЛА ИГРЫ НАЖМИТЕ ENTER/RETURN");
Console.ReadKey();
}

void Desk(string[,] mass)
          {
Console.Clear();
Console.WriteLine("    1      2      3  ");
Console.WriteLine(" ____________________");
Console.WriteLine("|      |      |      |");
Console.WriteLine($"|  {array[0,0]}   |  {array[0,1]}   |  {array[0,2]}   |  1");
Console.WriteLine("|______|______|______|");
Console.WriteLine("|      |      |      |");
Console.WriteLine($"|  {array[1,0]}   |  {array[1,1]}   |  {array[1,2]}   |  2");
Console.WriteLine("|______|______|______|");
Console.WriteLine("|      |      |      |");
Console.WriteLine($"|  {array[2,0]}   |  {array[2,1]}   |  {array[2,2]}   |  3");
Console.WriteLine("|______|______|______|");
          }

void StepTic()
{
       Console.WriteLine("Чтобы поставить  Крестик нужно ввести номер его клетки,");
       Console.WriteLine("Введите номер ряда, в котором расположена клетка и нажмите Enter/Return:");
       line = int.Parse(Console.ReadLine()!);
       Console.WriteLine("Введите номер столбца, в котором расположена клетка и нажмите Enter/Return:");
       column = int.Parse(Console.ReadLine()!);
}

void StepTac()
{
       Console.WriteLine("Чтобы поставить Нолик нужно ввести номер его клетки,");
       Console.WriteLine("Введите номер ряда, в котором расположена клетка и нажмите Enter/Return:");
       line = int.Parse(Console.ReadLine()!);
       Console.WriteLine("Введите номер столбца, в котором расположена клетка и нажмите Enter/Return:");
       column = int.Parse(Console.ReadLine()!);
}

void Check()
{
   if(array[0,0]==array[0,1] & array[0,0] == array[0,2] | 
   array[1,0]==array[1,1] & array[1,0] == array[1,2] |
   array[2,0]==array[2,1] & array[2,0] == array[2,2] |
   array[0,0]==array[1,0] & array[0,0] == array[2,0] |
   array[0,1]==array[1,1] & array[0,1] == array[2,1] |
   array[0,2]==array[1,2] & array[0,2] == array[2,2] |
   array[0,0]==array[1,1] & array[0,0] == array[2,2] |
   array[2,0]==array[1,1] & array[2,0] == array[0,2] )
   {
       win = true;
   }    
}


Instruction();
while(true)
{
Desk(array);
StepTic();
array[line-1,column-1] = "X";
Check();
Desk(array);
if(win == true)
   {
       Console.WriteLine("Победили Крестики! Поздравляю!!!");
       break;
   }
StepTac();
array[line-1,column-1] = "0";
Check();
Desk(array);
if(win == true)
   {
       Console.WriteLine("Победили Крестики! Поздравляю!!!");
       break;
   }
}

