namespace ClassLibrary1;

public class Point
{
    private double _x;
    private double _y;

    public double X
    {
        get => _x;
        set => _x = value;
    }

    public double Y
    {
        get => _y;
        set => _y = value;
    }

    public static Point operator +(Point point1, Point point2)
    {
        return new Point(point1.X + point2.X, point1.Y + point2.Y);
    }
    public static bool operator ! (Point point)
    {
        return point.X == 0 && point.Y == 0;
    }
    public Point()
    {
        this.X = 0;
        this.Y = 0;
    }
    public Point(Point point)
    {
        this.X = point.X;
        this.Y = point.Y;
    }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString()
    {
        return $"x: {X},y: {Y}\n";
    }
}

public class PolarCoorditates
{
    private double _r;
    private double _q;

    public double R
    {
        get => _r;
        set => _r = value;
    }

    public double Q
    {
        get => _q;
        set => _q = value;
    }

    public PolarCoorditates(double r, double q)
    {
        this.R = r;
        this.Q = q;
    }
}

public class Vector
{
    public Point Cords => new Point(B.X - A.X, B.Y - A.Y);

    public double Length => Math.Sqrt(Math.Pow(Cords.X, 2) + Math.Pow(Cords.Y, 2));
    public PolarCoorditates Polar => PolarCoorditates();

    private Point _a;
    private Point _b;
    public static Vector operator /(Vector vector, double number)
    {
        return new Vector(vector.A, new Point(vector.B.X / number, vector.B.Y / number));
    }
    public  static Vector operator /(double number, Vector vector)
    {
        return new Vector(vector.A, new Point(vector.B.X / number, vector.B.Y / number));
    }
    public static Vector operator +(Vector vector1, Vector vector2)
    {
        return new Vector(new Point(vector1.A + vector2.A), new Point(vector1.B + vector2.B));
    }
    public static bool operator > (Vector vector1, Vector vector2)
    {
        return vector1.Length > vector2.Length;
    }
    public static bool operator < (Vector vector1, Vector vector2)
    {
        return vector1.Length < vector2.Length;
    }
    public static Vector operator -- (Vector vector)
    {
        Vector vector1 = new Vector(vector);
        vector1.B.X--;
        vector1.B.Y--;
        return vector1;
    }
    public static bool operator ! (Vector vector)
    {
        return !vector.A || !vector.B; 
    }
    public Point A
    {
        get => _a;
        set => _a = value;
    }

    public Point B
    {
        get => _b;
        set => _b = value;
    }


    public PolarCoorditates PolarCoorditates()
    {
        var r = Math.Sqrt((Math.Pow(Cords.X, 2)) + Math.Pow(Cords.Y, 2));
        var q = Math.Atan2(Cords.Y, Cords.X);
        return new PolarCoorditates(r, q);
    }

    public Vector(Vector vector)
    {
        this.A = new Point(vector.A);
        this.B = new Point(vector.B);
    }
    public Vector()
    {
        this.A = new Point();
        this.B = new Point();
    }

    public Vector(Point a, Point b)
    {
        this.A = a;
        this.B = b;
    }
    

    public override string ToString()
    {
        return
            $"Point A: {A.ToString()}Point B: {B.ToString()}Coords:{Cords.ToString()}Polar: r= {Polar.R}, q= {Polar.Q}";
    }
}