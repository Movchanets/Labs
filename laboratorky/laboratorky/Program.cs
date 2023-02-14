using System;

namespace laboratorky
{
     class Program
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

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

        public class Vector
        {
            public Point Cords { get; set; }
            public Point A { get; set; }
            public Point B { get; set; }


            public (double r, double q) PolarCoorditates()
            {
                var r = Math.Sqrt((Math.Pow(Cords.X, 2)) + Math.Pow(Cords.Y, 2));
                var q = Math.Atan2(Cords.Y, Cords.X);

                return (q = q, r = r);
            }

            public Vector(Point a, Point b)
            {
                this.A = a;
                this.B = b;
                Cords = new Point(b.X - a.X, b.Y - a.Y);
            }

            public override string ToString()
            {
                var tuple = PolarCoorditates();
                return
                    $"Point A: {A.ToString()}Point B: {B.ToString()}Coords:{Cords.ToString()}Polar: r= {tuple.r}, q= {tuple.q}";
            }
        }

        static void Main(string[] args)
        {
            Vector vector = new Vector(new Point(1, 5), new Point(3, 7));
            var tuple = vector.PolarCoorditates();
            Console.WriteLine(vector.ToString());
        }
    }
}