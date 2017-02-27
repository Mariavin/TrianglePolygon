using System;

namespace ConsoleApplication38.Data
{
    public class Edge
    {
        public Edge(Point a, Point b)
        {
            this.PointFirst = a;
            this.PointSecond = b;
        }

        public Point PointFirst;

        public Point PointSecond;

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(PointSecond.X - PointFirst.X, 2) + Math.Pow(PointSecond.Y - PointFirst.Y, 2));
        }
    }
}
