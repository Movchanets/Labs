using System;
using ClassLibrary1;

namespace laboratorky
{
    class Program
    {
       static public void Input(ref Vector vector)
        {
            bool isInt = false;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            Console.WriteLine("Enter the first point");

            Console.WriteLine("Enter x:");


            while (!isInt)
            {
                isInt = int.TryParse(Console.ReadLine(), out x1);
            }

            isInt = false;
            Console.WriteLine("Enter y:");
            while (!isInt)
            {
                isInt = int.TryParse(Console.ReadLine(), out y1);
            }

            Console.WriteLine("Enter the second point");
            Console.WriteLine("Enter x:");
            isInt = false;
            while (!isInt)
            {
                isInt = int.TryParse(Console.ReadLine(), out x2);
            }

            Console.WriteLine("Enter y:");
            isInt = false;
            while (!isInt)
            {
                isInt = int.TryParse(Console.ReadLine(), out y2);
            }

           
                vector.A.X = x1;
                vector.A.Y = y1;
                vector.B.X = x2;
                vector.B.Y = y2;
            
        }

        static void Main(string[] args)
        {
            var vector = new Vector();

            while (true)
            {
                Input(ref vector);
                Console.WriteLine(vector);
                Console.WriteLine("Press any key to continue | Press Enter to exit");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {Console.Clear();
                    break;
                }

                Console.Clear();
            }

            Vector[] vectors = new Vector[28];


            for (int i = 0; i < vectors.Length / 2; i++)
            {
              // Input(ref vectors[i]); 
              Random random = new Random();
              vectors[i] = new Vector(new Point(random.Next(0, 100), random.Next(0, 100)),
                  new Point(random.Next(0, 100), random.Next(0, 100))); // rand for test
               Console.WriteLine(vectors[i]);
            }

            for (int i = 0; i <  vectors.Length / 2; i++)
            {
                vectors[vectors.Length - i - 1] = vectors[i];
                Console.WriteLine(vectors[i]);
            }
        }
    }
}