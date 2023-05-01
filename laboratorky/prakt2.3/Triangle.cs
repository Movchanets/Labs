namespace prakt2._3;

class Triangle: Figure
{
   
    private double _x1, _y1, _x2, _y2, _x3, _y3;
    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        this._x1 = x1;
        this._y1 = y1;
        this._x2 = x2;
        this._y2 = y2;
        this._x3 = x3;
        this._y3 = y3;
    }

   
    public override double Area()
    {
        return Math.Abs((_x1 * (_y2 - _y3) + _x2 * (_y3 - _y1) + _x3 * (_y1 - _y2)) / 2);
    }

   
    public override double Perimeter()
    {
        var a = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        var b = Math.Sqrt(Math.Pow(_x3 - _x2, 2) + Math.Pow(_y3 - _y2, 2));
        var c = Math.Sqrt(Math.Pow(_x1 - _x3, 2) + Math.Pow(_y1 - _y3, 2));
        return a + b + c;
    }
}