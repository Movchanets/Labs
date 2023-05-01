using System;
using System.Collections.Generic;

public class Strings
{
    protected List<char> value;

    public Strings(List<char> value)
    {
        this.value = value;
    }

    public int Length()
    {
        return value.Count;
    }

    public override string ToString()
    {
        return new string(value.ToArray());
    }
}

public class NumericStrings : Strings
{
    public NumericStrings(List<char> value) : base(value)
    {
        // Перевірка на введення числа
        foreach (char c in value)
        {
            if (!Char.IsDigit(c))
            {
                throw new ArgumentException("Value must be a numeric string");
            }
        }
    }

    public List<char> Reverse()
    {
        value.Reverse();
        return value;
    }

   
}

public class Program
{
    public static void Main()
    {
        List<Strings> stringsList = new List<Strings>();

        while (true)
        {
            Console.WriteLine("Select class: 1. Strings, 2. NumericStrings, 3. Exit");
            int classChoice = int.Parse(Console.ReadLine());

            if (classChoice == 3)
            {
                break;
            }

            Console.WriteLine("Enter value:");
            string value = Console.ReadLine();
            List<char> chars = new List<char>(value.ToCharArray());

            Strings stringsObj;
            if (classChoice == 2)
            {
                try
                {
                    stringsObj = new NumericStrings(chars);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            else
            {
                stringsObj = new Strings(chars);
            }

            stringsList.Add(stringsObj);
            Console.WriteLine("Object added");

            while (true)
            {
                Console.WriteLine("Select function: 1. Get value, 2. Get length, 3. Reverse, 4. Create new object, 5. Exit");
                int functionChoice = int.Parse(Console.ReadLine());

                switch (functionChoice)
                {
                    case 1:
                        Console.WriteLine("Value: " + stringsObj);
                        break;
                    case 2:
                        Console.WriteLine("Length: " + stringsObj.Length());
                        break;
                    case 3:
                        if (classChoice != 2)
                        {
                            Console.WriteLine("Error: Reverse function only available for NumericStrings");
                            break;
                        }
                        Console.WriteLine("Reversed Value: " + new string(((NumericStrings) stringsObj).Reverse().ToArray()));
                        break;
                    case 4:
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                if (functionChoice == 4)
                {
                    break;
                }
            }
        }
    }
}
