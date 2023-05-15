// See https://aka.ms/new-console-template for more information

using System;

namespace prakt2_5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Введіть тип даних (int, double або float), або введіть 'вийти', щоб вийти з програми:");
                string dataTypeInput = Console.ReadLine().ToLower();

                if (dataTypeInput == "вийти")
                {
                    break;
                }
                if(dataTypeInput != "int" && dataTypeInput != "double" && dataTypeInput != "float")
                {
                    Console.WriteLine("Неправильний ввід");
                    continue;
                }

                switch (dataTypeInput)
                {
                    case "int":
                    {
                        Console.WriteLine("Введіть координати вершин прямокутника (x1 y1 x2 y2 x3 y3):");
                        Console.WriteLine("Введіть x1:");
                        var x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y1:");
                        var y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x2:");
                        var x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y2:");
                        var y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x3:");
                        var x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y3:");
                        var y3 = int.Parse(Console.ReadLine());
                        Rectangle<int> rect = new Rectangle<int>(new Point<int>(x1, y1), new Point<int>(x2, y2), new Point<int>(x3, y3));
                        rect.Info();
                        break;
                    }
                    case "double":
                    {
                        Console.WriteLine("Введіть координати вершин прямокутника (x1 y1 x2 y2 x3 y3):");
                        Console.WriteLine("Введіть x1:");
                        var x1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y1:");
                        var y1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x2:");
                        var x2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y2:");
                        var y2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x3:");
                        var x3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y3:");
                        var y3 = double.Parse(Console.ReadLine());
                        Rectangle<double> rect = new Rectangle<double>(new Point<double>(x1, y1), new Point<double>(x2, y2), new Point<double>(x3, y3));
                        rect.Info();
                        break;
                    }
                    case "float":
                    {
                        Console.WriteLine("Введіть координати вершин прямокутника (x1 y1 x2 y2 x3 y3):");
                        Console.WriteLine("Введіть x1:");
                        var x1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y1:");
                        var y1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x2:");
                        var x2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y2:");
                        var y2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть x3:");
                        var x3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть y3:");
                        var y3 = float.Parse(Console.ReadLine());
                        Rectangle<float> rect = new Rectangle<float>(new Point<float>(x1, y1), new Point<float>(x2, y2), new Point<float>(x3, y3));
                        rect.Info();
                        break;
                    }
                }
            }
        }
    }
}
