namespace prakt2_5;

public class Point<T>
{
   private T x;
   private T y;

   public T X { get => x; set => x = value; } 
   public T Y { get => y; set => y = value; }

    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }

    public Point() { }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
