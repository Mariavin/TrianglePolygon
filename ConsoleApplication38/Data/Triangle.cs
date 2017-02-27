using System;

namespace ConsoleApplication38.Data
{
    public class Triangle
    {
        public Triangle(Point a, Point b, Point c)
        {
            EdgeFirst = new Edge(a, b);
            EdgeSecond = new Edge(b, c);
            EdgeThird = new Edge(c, a);
        }

        private Edge EdgeFirst;

        private Edge EdgeSecond;

        private Edge EdgeThird;

        public double GetPerimetr()
        {
            return EdgeFirst.GetLength() + EdgeSecond.GetLength() + EdgeThird.GetLength();
        }

        public double GetArea()
        {
            var semiperimeter = GetPerimetr() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - EdgeFirst.GetLength()) * (semiperimeter - EdgeSecond.GetLength()) * (semiperimeter - EdgeThird.GetLength()));
        }

        public bool IsIsosceles()
        {
            return (EdgeFirst.GetLength() == EdgeSecond.GetLength()
                    || EdgeFirst.GetLength() == EdgeThird.GetLength()
                    || EdgeSecond.GetLength() == EdgeThird.GetLength()) ? true : false;
        }

        public bool Rigth()
        {
            return (CheckPythagorasTheorem(EdgeFirst.GetLength(), EdgeSecond.GetLength(), EdgeThird.GetLength())) ? true : false;
        }

        private bool CheckPythagorasTheorem(double LengthEdgeFirst, double LengthEdgeSecond, double LengthEdgeThird)
        {
            return (Math.Pow(LengthEdgeFirst, 2) + Math.Pow(LengthEdgeSecond, 2) == Math.Pow(LengthEdgeThird, 2)
                    || Math.Pow(LengthEdgeFirst, 2) + Math.Pow(LengthEdgeThird, 2) == Math.Pow(LengthEdgeSecond, 2)
                    || Math.Pow(LengthEdgeSecond, 2) + Math.Pow(LengthEdgeThird, 2) == Math.Pow(LengthEdgeFirst, 2)
                    ) ? true : false;
        }
    }
}
