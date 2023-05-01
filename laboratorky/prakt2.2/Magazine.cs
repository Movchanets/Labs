namespace prakt2._2;

class Magazine : PrintedItem
{
    protected double productionCost;
    protected int numberOfCopiesSold;
    protected double advertisingSpace;
    protected double advertisingRate;

    public Magazine(int numberOfPages, string publisher, double price, string title, string issueNumber,
        double productionCost,  int numberOfCopiesSold,
        double advertisingSpace, double advertisingRate)
        : base(numberOfPages, publisher, price, title)
    {
        this.productionCost = productionCost;
        this.numberOfCopiesSold = numberOfCopiesSold;
        this.advertisingSpace = advertisingSpace;
        this.advertisingRate = advertisingRate;
    }

    public override double CalculateRetailPrice()
    {
        var retailPrice = (price +  (productionCost + advertisingSpace * advertisingRate) / numberOfCopiesSold) * 1.2;
       
        return  Math.Round(retailPrice, MidpointRounding.AwayFromZero);
    }


    public double ProductionCost
    {
        get => productionCost;
        set => productionCost = value;
    }


    public int NumberOfCopiesSold
    {
        get => numberOfCopiesSold;
        set => numberOfCopiesSold = value;
    }

    public double AdvertisingSpace
    {
        get => advertisingSpace;
        set => advertisingSpace = value;
    }

    public double AdvertisingRate
    {
        get => advertisingRate;
        set => advertisingRate = value;
    }
}