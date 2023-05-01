using System;
using prakt2._2;

static class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1. Створити книгу");
            Console.WriteLine("2. Створити журнал");
            Console.WriteLine("3. Вийти");
            Console.Write("Введіть номер опції: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateBook();
                    break;
                case "2":
                    CreateMagazine();
                    break;
                case "3":
                    Console.WriteLine("До побачення!");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static void CreateBook()
    {
        Console.Write("Введіть кількість сторінок: ");
        var numberOfPages = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть видавця: ");
        var publisher = Console.ReadLine();
        Console.Write("Введіть ціну: ");
        var price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть назву: ");
        var title = Console.ReadLine();
        Console.Write("Введіть автора: ");
        var author = Console.ReadLine();
        var book = new Book(numberOfPages, publisher, price, title, author);
        Console.WriteLine("Книга створена успішно!");
        Console.WriteLine("Роздрібна вартість книги: " + book.CalculateRetailPrice());
    }

    static void CreateMagazine()
    {
        Console.Write("Введіть кількість сторінок: ");
        var numberOfPages = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть видавця: ");
        var publisher = Console.ReadLine();
        Console.Write("Введіть ціну: ");
        var price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть назву: ");
        var title = Console.ReadLine();
        Console.Write("Введіть номер випуску: ");
        var issueNumber = Console.ReadLine();
        Console.Write("Введіть виробничі витрати: ");
        var productionCost = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть кількість проданих копій: ");
        var numberOfCopiesSold = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть рекламну площу: ");
        var advertisingSpace = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть рекламну ставку: ");
        var advertisingRate = Convert.ToDouble(Console.ReadLine());
        var magazine = new Magazine(numberOfPages, publisher, price, title, issueNumber, productionCost,
            numberOfCopiesSold, advertisingSpace, advertisingRate);
        Console.WriteLine("Журнал створений успішно!");
        Console.WriteLine("Роздрібна вартість журналу: " + magazine.CalculateRetailPrice());
    }
}