using System;
using prakt2_4;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Виберіть тип об'єкта, з яким хочете працювати:");
        Console.WriteLine("1 - SmallLettersString");
        Console.WriteLine("2 - СapitalLettersString");
        Console.Write("Ваш вибір: ");

        int choice = int.Parse(Console.ReadLine());

        ISortingString objectToSort = null;
        bool IsCapital = false;
        switch (choice)
        {
            case 1:
                Console.Write("Введіть рядок для створення об'єкта SmallLettersString: ");
                string input1 = Console.ReadLine();

                objectToSort = new SmallLettersString(input1);
                break;
            case 2:
                Console.Write("Введіть рядок для створення об'єкта СapitalLettersString: ");
                string input2 = Console.ReadLine();
                IsCapital = true;
                objectToSort = new CapitalLettersString(input2);
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }

        if (objectToSort != null)
        {
            Console.WriteLine("Обраний об'єкт: " + objectToSort.GetType().Name);
            var val = IsCapital
                ? (objectToSort as CapitalLettersString).Value
                : (objectToSort as SmallLettersString).Value;
            Console.WriteLine("Вихідний рядок: " + val);

            Console.WriteLine("Сортування...");
            objectToSort.Sort();
            val = IsCapital
                ? (objectToSort as CapitalLettersString).Value
                : (objectToSort as SmallLettersString).Value;
            Console.WriteLine("Результат: " + val);
        }

        Console.WriteLine("Натисніть будь-яку клавішу, щоб вийти.");
        Console.ReadKey();
    }
}