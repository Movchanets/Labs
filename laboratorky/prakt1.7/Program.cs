using System.Text;

namespace prakt1._7;

public class SymbolArray
{
    private char[] _arr;

    public SymbolArray(int size)
    {
        _arr = new char[size];
    }

    public char this[int index]
    {
        get
        {
            if (index < 0 || index >= _arr.Length)
            {
                Console.WriteLine("Помилка: некоректний індекс!");
                return '\0';
            }
            else
            {
                return char.ToUpper(_arr[index]);
            }
        }
        set
        {
            if (index < 0 || index >= _arr.Length)
            {
                Console.WriteLine("Помилка: некоректний індекс!");
            }
            else
            {
                _arr[index] = value;
            }
        }
    }

    public int VowelsCount
    {
        get
        {
            return _arr.Count(t => t is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U');
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        SymbolArray arr = new SymbolArray(5);

        arr[0] = 'a';
        arr[1] = 'b';
        arr[2] = 'c';
        arr[3] = 'd';
        arr[4] = 'e';

        Console.WriteLine("Елементи масиву у верхньому регістрі:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Кількість голосних літер: " + arr.VowelsCount);

        Console.ReadLine();
    }
}