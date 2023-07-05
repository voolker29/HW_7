var intList = new List<int>();
Random random = new Random();
for (int i = 0; i < 15; i++)
{
    intList.Add(random.Next(150));

}

ShowList(intList);
intList.Sort();
Console.WriteLine(new string('-',15));
ShowList(intList);
Console.WriteLine("Отсортировано по возрастанию") ;
Console.WriteLine(new string('-', 15));

var devided = intList.Where(x => x%2 == 0);
ShowList(devided.ToList());
Console.WriteLine("Отсортировано по делению на 2 без остатка");
Console.WriteLine(new string('-', 15));
var more42 = intList.Where(x => x > 42).ToList();
ShowList(more42);
Console.WriteLine("Отсортировано по больше  42");
Console.WriteLine(new string('-', 15));

Console.WriteLine("Общая Сумма");
Console.WriteLine(intList.Sum());
Console.WriteLine(new string('-', 15));


void ShowList(List<int> iterationlist)
{

    foreach (int i in iterationlist)
    {
        Console.WriteLine(i);
    }


}

