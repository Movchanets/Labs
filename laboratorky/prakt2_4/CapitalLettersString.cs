namespace prakt2_4;
class CapitalLettersString : ISortingString
{
    public string Value;

    public CapitalLettersString(string value)
    {
        this.Value = value.ToUpper();
    }

    public int Length => Value.Length;

    public void Sort()
    {
        var chars = Value.ToCharArray();
        Array.Sort(chars, (a, b) => b.CompareTo(a));
        Value = new string(chars);
    }
}