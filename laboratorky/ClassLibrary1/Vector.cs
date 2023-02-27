namespace ClassLibrary1;

public class Point
{
    private int x;
    private int y;

    public int X
    {
        get => x;
        set => x = value;
    }

    public int Y
    {
        get => y;
        set => y = value;
    }

    public Point()
    {
        this.X = 0;
        this.Y = 0;
    }

    public Point(int x, int y)
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
    private double r;
    private double q;

    public double R
    {
        get => r;
        set => r = value;
    }

    public double Q
    {
        get => q;
        set => q = value;
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


    public PolarCoorditates Polar => PolarCoorditates();

    private Point _a;
    private Point _b;

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