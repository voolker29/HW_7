using ClassCircle;
using ClassSquare;
using ClassSquare;
using System.Text;
using ClassTriangle;

var stringMenu = new StringBuilder();
stringMenu.AppendLine("1.Посчитать площадь круга");
stringMenu.AppendLine("2.Посчитать площадь квадрата");
stringMenu.AppendLine("3.Посчитать площадь треугольника");
stringMenu.AppendLine("4.Выйти");
stringMenu.AppendLine("Выберите действие.");



while (true)
{
    ShowSplitLine();
    Console.Write(stringMenu.ToString());
    var action = Console.ReadLine();
    
    if (action == "4")
    {
        break;
    }

    switch (action)
    {
        case "1":

         Console.WriteLine("Введите числове значение для 'r'");
         var r = Convert.ToDouble(Console.ReadLine());

         var circle = new Circle(r);
         Console.WriteLine($"S = {circle.GetSquare()}");

            break;
        case "2":
            Console.WriteLine("Введите числове значение для 'a'");
            var a = Convert.ToDouble(Console.ReadLine());

            var square = new Square(a);
            Console.WriteLine($"S = {square.GetSquare()}");

            break;
        case "3":

            Console.WriteLine("Введите числове значение для 'a'");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите числове значение для 'h'");
            var h = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle(a,h);
            Console.WriteLine($"S = {triangle.GetSquare()}");

            break;
       


        default:
            Console.WriteLine("Действие не распознано");
            break;
    }




}






void ShowSplitLine()
{

    Console.WriteLine(new string('-', 50));

}