// На столе лежит N конфет. Играют компьютер и человек.
// Первым ходит ПК, далее человек и т.д.
// За один ход можно со стола взять 
// не более N/2 конфету, но не менее 1 конфет за ход. 
// Побеждает тот, кто забирает конфеты последним ходом. 
// Хотел бы предложить написать код для гарантированной победы того, кто начинает первым

Console.Clear();
int num = new Random().Next(50,101);
if(num%2!=0) num+=1;
int maxHungry = num/2;
Console.WriteLine($"На столе лежат {num} конфет");
Console.WriteLine($"Игроки могут взять за раз не больше половины ({maxHungry}) конфет и не менее 1");
Console.WriteLine($"Для начала игры нажмите ENTER");
Console.ReadKey();

    int countAI = (int)maxHungry - 1; 
    Console.WriteLine($"Ход ИИ");
    Console.WriteLine($"ИИ берет {countAI} конфет");
    num -= countAI;
    Console.WriteLine($"\nНа столе осталось {num} конфет");
    Console.WriteLine($"\nХод Хомосапиуса");
    Console.WriteLine("Сколько берешь конфет?");
    int countHomo = int.Parse(Console.ReadLine()!); 
    num -= countHomo;
    Console.WriteLine($"\nНа столе осталось {num} конфет");
     Console.WriteLine($"Для продолжения игры нажмите ENTER");
    Console.ReadKey();

    countAI = num; 
    Console.WriteLine($"Ход ИИ");
    Console.WriteLine($"ИИ берет {countAI} конфет и на столе нифига не осталось)))");
    Console.WriteLine($"Игра окончена, выиграл ИИ");
