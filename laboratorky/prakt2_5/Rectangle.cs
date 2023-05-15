

using Microsoft.VisualBasic.CompilerServices;

namespace prakt2_5;

public class Rectangle<T> 
{
    private Point<T> point1;
    private Point<T> point2;
    private Point<T> point3;
    private Point<T> point4;
    private Point<T> center;

    public Rectangle(Point<T> p1, Point<T> p2, Point<T> p3)
    {
        if (IsRectangle(p1, p2, p3))
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = new Point<T>(p1.X, p3.Y);
            center = new Point<T>((dynamic) p1.X + (dynamic) point4.X / 2, (dynamic) p1.Y + (dynamic) point4.Y / 2);
        }
        else
        {
            throw new ArgumentException("The provided points do not form a rectangle.");
        }
    }

    private bool IsRectangle(Point<T> p1, Point<T> p2, Point<T> p3)
    {
        // Перевіряємо, щоб координати точок утворювали прямокутний трикутник
        var s1 = Math.Sqrt(Math.Pow((dynamic) p1.X - (dynamic) p2.X, 2) + Math.Pow((dynamic) p1.Y - (dynamic) p2.Y, 2));
        var s2 = Math.Sqrt(Math.Pow((dynamic) p2.X - (dynamic) p3.X, 2) + Math.Pow((dynamic) p2.Y - (dynamic) p3.Y, 2));
        var s3 = Math.Sqrt(Math.Pow((dynamic) p3.X - (dynamic) p1.X, 2) + Math.Pow((dynamic) p3.Y - (dynamic) p1.Y, 2));
        var max = Math.Max(s1, Math.Max(s2, s3));
        
       return Math.Pow(s1, 2) + Math.Pow(s2, 2) + Math.Pow(s3, 2) - Math.Pow(max, 2) > Math.Pow(max, 2) - 0.01 ;
            
    }


    public double GetLength(int sideNumber)
    {
        switch (sideNumber)
        {
            case 1: return Math.Sqrt(Math.Pow((dynamic) point1.X - (dynamic) point2.X, 2) + Math.Pow((dynamic) point1.Y - (dynamic) point2.Y, 2));
            case 2: return Math.Sqrt(Math.Pow((dynamic) point2.X - (dynamic) point3.X, 2) + Math.Pow((dynamic) point2.Y - (dynamic) point3.Y, 2));
            case 3: return Math.Sqrt(Math.Pow((dynamic) point3.X - (dynamic) point4.X, 2) + Math.Pow((dynamic) point3.Y - (dynamic) point4.Y, 2));
            case 4: return Math.Sqrt(Math.Pow((dynamic) point4.X - (dynamic) point1.X, 2) + Math.Pow((dynamic) point4.Y - (dynamic) point1.Y, 2));
            default: throw new ArgumentException("The provided side number is not valid.");
        }
        
    }
    public double GetPerimeter()
    {
       return GetLength(1) + GetLength(2) + GetLength(3) + GetLength(4);
    }

    public double GetArea()
    {
        return GetLength(1) * GetLength(2);
    }

    public void ChangeRectangle(Rectangle<T> newRectangle)
    {
        point1 = newRectangle.point1;
        point2 = newRectangle.point2;
        point3 = newRectangle.point3;
        point4 = newRectangle.point4;
        center = newRectangle.center;
    }

    public void Info()
    {
        Console.WriteLine($"Rectangle with points: {point1}, {point2}, {point3}, {point4} and center: {center}");
        Console.WriteLine($"Довжина першої сторони: {GetLength(1)}");
        Console.WriteLine($"Довжина другої сторони: {GetLength(2)}");
        Console.WriteLine($"Довжина третьої сторони: {GetLength(3)}");
        Console.WriteLine($"Довжина четвертої сторони: {GetLength(4)}");
        Console.WriteLine($"Периметр: {GetPerimeter()}");
        Console.WriteLine($"Площа: {GetArea()}");
    }
    public override string ToString()
    {
        return $"Rectangle with points: {point1}, {point2}, {point3}, {point4} and center: {center}";
    }
}
