using System;
using prakt2._3;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Figure figure = null;
        while (true)
        {
            Console.WriteLine("Оберіть фігуру:");
            Console.WriteLine("1 - Трикутник");
            Console.WriteLine("2 - Коло");
            Console.WriteLine("3 - Вихід");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть координати вершин трикутника (x1 y1 x2 y2 x3 y3): ");
                    string[] coordinates = Console.ReadLine().Split();
                    if(coordinates.Length != 6)
                    {
                        Console.WriteLine("Неправильний ввід");
                        break;
                    }
                    double x1 = double.Parse(coordinates[0]);
                    double y1 = double.Parse(coordinates[1]);
                    double x2 = double.Parse(coordinates[2]);
                    double y2 = double.Parse(coordinates[3]);
                    double x3 = double.Parse(coordinates[4]);
                    double y3 = double.Parse(coordinates[5]);
                    figure = new Triangle(x1, y1, x2, y2, x3, y3);
                    break;
                case 2:
                    Console.Write("Введіть радіус кола: ");
                    double radius = double.Parse(Console.ReadLine());
                    figure = new Circle(radius);
                    break;
                   case 3:
                       return;
                    
                default:
                    Console.WriteLine("Неправильний вибір");
                    break;
            }

            if (figure != null)
            {
                bool exit2 = false;
                while (!exit2)
                {
                    Console.WriteLine("Оберіть функцію:");
                    Console.WriteLine("1 - Площа");
                    Console.WriteLine("2 - Периметр");
                    Console.WriteLine("3 - Вихід");

                    int function = int.Parse(Console.ReadLine());

                    switch (function)
                    {
                        case 1:
                            Console.WriteLine("Площа фігури: " + figure.Area());
                            break;
                        case 2:
                            Console.WriteLine("Периметр фігури: " + figure.Perimeter());
                            break;
                        case 3:
                            exit2 = true;
                            break;
                        default:
                            Console.WriteLine("Неправильний вибір");
                            break;
                    }
                }
            }
        }
    }
}