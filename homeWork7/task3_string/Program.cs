var listString = new List<string>() {"Добропожаловать",
                                     "ПродолжаемОбучение",
                                     "Обучение Идет полным ходом",
                                     "когда нибудь я это все выучу",
                                     "А C# хорош",
                                     "привет1 мир"};

var noprobels = listString.Where(x => x.Contains(" ") == false);
ShowList(noprobels.ToList());
Console.WriteLine("**Выведена коллекция без пробелов");
Console.WriteLine(new string('-', 15));

ShowList(listString.Where(x => x.ToLowerInvariant() != x).ToList());
Console.WriteLine("**Выведена коллекция с заглавными буквами");
Console.WriteLine(new string('-', 15));

Console.WriteLine("Введите слово для поиска");
var word = Console.ReadLine();
ShowList(listString.Where(x => x.Contains(word)).ToList());
Console.WriteLine("**Выведена колекция которая содержит введенное слово");
Console.WriteLine(new string('-', 15));


Console.WriteLine(listString.Any(x => x.Any(b=> char.IsDigit(b))));
Console.WriteLine("**Выведено есть ли в коолекции число");
Console.WriteLine(new string('-', 15));





void ShowList(List<string> iterationlist)
{

    foreach (string i in iterationlist)
    {
        Console.WriteLine(i);
    }


}
