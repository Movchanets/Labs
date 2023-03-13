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

            if (vector == null)
            {
                vector = new Vector(new Point(x1, y1), new Point(x2, y2));
            }else{
                vector.A.X = x1;
                vector.A.Y = y1;
                vector.B.X = x2;
                vector.B.Y = y2;
            }
        }   
       static public void Input(ref StringNumber stringNumber)
       {
           if(stringNumber == null)
           {
               stringNumber = new StringNumber();
           }
           bool isInt = false;
            int choice = 0;
            while (true)
            {
                Console.WriteLine(@"Select the operation: 
                                \n 1 -Show StringNumber 
                                \n 2 -Add char 
                                \n 3 -Add StringNumber
                                \n 4 -Remove at index
                                \n 5 Get char at index
                                \n 6 Get Length
                                \n 7 Set Number
                                \n 8 Reverse
                ");
                while (!isInt)
                {
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                }
                isInt = false;
             
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine(stringNumber);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter char");
                        stringNumber.Add( Console.ReadLine()[0]);
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Add String");
                        stringNumber.AddRange((Console.ReadLine()).ToCharArray());
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Enter index to delete");
                        int index = 0;
                        while (!isInt)
                        {
                            isInt = int.TryParse(Console.ReadLine(), out index);
                        } 
                        isInt = false;
                        stringNumber.RemoveAt(index);
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Enter index to get char");
                        int index = 0;
                        while (!isInt)
                        {
                            isInt = int.TryParse(Console.ReadLine(), out index);
                        } 
                        isInt = false;
                        Console.WriteLine(stringNumber[index]);
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine(stringNumber.Length);
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("Enter number");
                        int number = 0;
                        while (!isInt)
                        {
                            isInt = int.TryParse(Console.ReadLine(), out number);
                        } 
                        isInt = false;
                       stringNumber.SetNumber(number.ToString());
                        break;
                    }
                    case 8:
                    {
                        stringNumber.Reverse();
                        break;
                    }
                }
                Console.WriteLine("Press any key to continue | Press Enter to exit");
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                    
                    
                }
                Console.Clear();
            }
       }
       static void Main(string[] args)
        {
            // var vector = new Vector();
            //
            // while (true)
            // {
            //     Input(ref vector);
            //     Console.WriteLine(vector);
            //     Console.WriteLine("Press any key to continue | Press Enter to exit");
            //     if (Console.ReadKey().Key == ConsoleKey.Enter)
            //     {Console.Clear();
            //         break;
            //     }
            //
            //     Console.Clear();
            // }
            //
            // Vector[] vectors = InputVectors();
          StringNumber stringNumber1 = new StringNumber("123");
          StringNumber stringNumber2 = new StringNumber("232");
          Console.WriteLine((stringNumber1 ^ stringNumber2) + " : ^ додавання як числа");
          Console.WriteLine(stringNumber1 *32 + " : * добавлення 32 в кінець 123 * 32");
          Console.WriteLine(32 * stringNumber1  + " : * добавлення 32 в початок  32  * 123 ");
            Console.WriteLine(stringNumber1 + stringNumber2 + " : + додавання як строки");
            Console.WriteLine((stringNumber1 == stringNumber2 )+ " : == перевірка на рівність");
            Console.WriteLine((stringNumber1 != stringNumber2 )+ " : != перевірка на нерівність");
            Console.WriteLine((stringNumber1--) + " : -- пост декремент");
            Console.WriteLine((--stringNumber1) + " : -- пре декремент");
            if (stringNumber1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
          
           StringNumber [] stringNumbers = InputStringNumbers();
             for (int i = 0; i < stringNumbers.Length; i++)
            {
                Console.WriteLine(stringNumbers[i]);
             }
            
            // Vector vector1 = new Vector(new Point(1, 1), new Point(2, 2));
            // Console.WriteLine("vector1 / double");
            // vector1 = vector1 / 2.5;
            // Console.WriteLine(vector1);
            // Console.WriteLine( "double / vector : "  );
            // vector1 = 1.5 / vector1;
            // Console.WriteLine(vector1);
            // Vector vector2 = new Vector(new Point(1, 1), new Point(2, 2));
            // Console.WriteLine("vector1 + vector2");
            // vector1 = vector1 + vector2;
            // Console.WriteLine(vector1);
            // Console.WriteLine("vector>vector2: " + (vector1 > vector2));
            // Console.WriteLine("vector--");
            // Console.WriteLine(vector2);
            // Console.WriteLine(vector2-- + " : returned old value");
            // Console.WriteLine(vector2 + " : new value");
            // Console.WriteLine( "!vector :" + !vector2);

        }
        static StringNumber[] InputStringNumbers(int size = 28)
        {
            StringNumber[] stringNumbers = new StringNumber[size];
            Random random = new Random();
            for (int i = 0; i < stringNumbers.Length / 2; i++)
            {
                // Input(ref stringNumbers[i]); 
                stringNumbers[i] = new StringNumber(random.Next(0, 10000).ToString());  // rand for test              
                
            }

            for (int i = 0; i <  stringNumbers.Length / 2; i++)
            {
                stringNumbers[stringNumbers.Length - i - 1] = new StringNumber(stringNumbers[i]);
              
            }

            
            return stringNumbers;
        }
        static Vector[] InputVectors(int size = 28)
        {
            Vector[] vectors = new Vector[size];
            for (int i = 0; i < vectors.Length / 2; i++)
            {
                Input(ref vectors[i]); 
           
                //Random random = new Random();
                //   vectors[i] = new Vector(new Point(random.Next(0, 100), random.Next(0, 100)),
                //     new Point(random.Next(0, 100), random.Next(0, 100))); // rand for test
                Console.WriteLine(vectors[i]);
            }

            for (int i = 0; i <  vectors.Length / 2; i++)
            {
                vectors[vectors.Length - i - 1] = new Vector(vectors[i]);
                Console.WriteLine(vectors[i]);
            }

            return vectors;
        }
    }
}