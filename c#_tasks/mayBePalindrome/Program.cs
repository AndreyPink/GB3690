Console.WriteLine("Введите слово:");
string text = Console.ReadLine()!;
string newText = "";
int len = text.Length;
for (int i = 0; i < len; i++)
{
    bool check = newText.Contains(text[i]);
    if (!check)
    {
        newText += text[i];
    }
    else
    {
        string elem = (text[i]).ToString();
        newText = newText.Replace(elem, "");
        // newText = Regex.Replace(newText,elem , "");
    }
}
if (newText.Length < 2)
{
    Console.WriteLine("Из этого слова можно составить палиндром");
}
else
{
    Console.WriteLine("Из этого слова нельзя составить палиндром");
}
