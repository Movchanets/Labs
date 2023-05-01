namespace prakt2._2;

class PrintedItem
{
    protected int numberOfPages;
    protected string publisher;
    protected double price;
    protected string title;

    public PrintedItem(int numberOfPages, string publisher, double price, string title)
    {
        this.numberOfPages = numberOfPages;
        this.publisher = publisher;
        this.price = price;
        this.title = title;
    }

    public virtual double CalculateRetailPrice()
    {
        return price;
    }

    public int NumberOfPages
    {
        get => numberOfPages;
        set => numberOfPages = value;
    }

    public string Publisher
    {
        get => publisher;
        set => publisher = value;
    }

    public double Price
    {
        get => price;
        set => price = value;
    }

    public string Title
    {
        get => title;
        set => title = value;
    }
}