namespace prakt2._2;

class Book : PrintedItem
{
    protected string author;

    public Book(int numberOfPages, string publisher, double price, string title, string author) : base(numberOfPages,
        publisher, price, title)
    {
        this.author = author;
    }

    public override double CalculateRetailPrice()
    {
        return  Math.Round((price * 1.15) * 1.2, MidpointRounding.AwayFromZero);
    }

    public string Author
    {
        get => author;
        set => author = value;
    }
}