namespace prakt2_4;

class SmallLettersString : ISortingString
{
    public string Value;

    public SmallLettersString(string value)
    {
        this.Value = value.ToLower();
    }

    public int Length
    {
        get { return Value.Length; }
    }

    public void Sort()
    {
        var chars = Value.ToCharArray();
        Array.Sort(chars);
        Value = new string(chars);
    }
}