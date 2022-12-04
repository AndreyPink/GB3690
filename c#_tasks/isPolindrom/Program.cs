Console.WriteLine("Введите слово:");
string text = Console.ReadLine()!;
int len = text.Length;
if(text.Length % 2 == 0)
{
    string text1 = text.Substring(0, len / 2);
    string text2 =  text.Substring(len / 2, len / 2);
    string text2rev = new string(text2.ToCharArray().Reverse().ToArray());
    
    // Console.WriteLine(text1);
    // Console.WriteLine(text2);
    // Console.WriteLine(text2rev);

    if(text1 == text2rev)
    {
        Console.WriteLine($"Слово {text} Является палиндромом");
    }
    else {Console.WriteLine($"Слово {text}  Не является палиндромом");}
}
else
{
    string text1 = text.Substring(0, (len - 1) / 2);
    string text2 =  text.Substring((len - 1) / 2 + 1, (len - 1) / 2);
    string text2rev = new string(text2.ToCharArray().Reverse().ToArray());

    // Console.WriteLine(text1);
    // Console.WriteLine(text2);
    // Console.WriteLine(text2rev);

    if(text1 == text2rev)
    {
        Console.WriteLine($"Слово {text} Является палиндромом");
    }
    else {Console.WriteLine($"Слово {text}  Не является палиндромом");}
}
