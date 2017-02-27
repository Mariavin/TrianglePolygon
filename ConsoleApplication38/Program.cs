using ConsoleApplication38.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        public static void Print(Triangle h)
        {
            Console.WriteLine(String.Format("{0:0.00}", h.GetPerimetr()));
            Console.WriteLine(String.Format("{0:0.00}", h.GetArea()));

            if (h.IsIsosceles())
            {
                Console.WriteLine("Треугольник равнобедренный");
            }

            if (h.Rigth())
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
        }

        static void Main(string[] args)
        {
            Triangle TriangleTest = new Triangle(new Point(2, 2), new Point(2, 8), new Point(0, 4));
            Print(TriangleTest);

            Console.WriteLine("//===================================");

            Triangle[] Mass = new Triangle[4];

            Mass[0] = new Triangle(new Point(0, 0), new Point(4, 6), new Point(8, 0));//равнобедренный
            Mass[1] = new Triangle(new Point(2, 2), new Point(2, 8), new Point(6, 2));//
            Mass[2] = new Triangle(new Point(1, 1), new Point(1, 5), new Point(5, 1));//равнобедренный
            Mass[3] = new Triangle(new Point(2, 1), new Point(2, 5), new Point(7, 1));//прямоугольный

            List<Triangle> MassTriangle = new List<Triangle>();
            MassTriangle.Add(Mass[0]);
            MassTriangle.Add(Mass[1]);
            MassTriangle.Add(Mass[2]);
            MassTriangle.Add(Mass[3]);

            double sumP = 0;
            double sumA = 0;
            int count1 = 0;
            int count2 = 0;

            foreach (var k in MassTriangle)
            {
                if (k.IsIsosceles())
                {
                    sumA += k.GetArea();
                    count1++;
                }

                if (k.Rigth())
                {
                    sumP += k.GetPerimetr();
                    count2++;
                }
            }

            Console.WriteLine("Cредняя площадь всех равнобедренных треугольников равна {0}", String.Format("{0:0.00}", sumA / count1));
            Console.WriteLine("Средний периметр всех прямоугольных треугольников равен {0}", String.Format("{0:0.00}", sumP / count2));

            Console.WriteLine("//===================================");
            Console.WriteLine("Работаем с многоугольником:");

            Point[] rectangle = new Point[] { new Point(0, 0), new Point(5, 0), new Point(5, 3), new Point(0, 3) };
            Point[] pentagon = new Point[] { new Point(2, 0), new Point(4, 0), new Point(5, 2), new Point(3, 4), new Point(1, 2) };

            Polygon PolygonTestZero = new Polygon(rectangle);
            Polygon PolygonTestFirst = new Polygon(pentagon);

            Console.WriteLine("Периметр четырехугольника:{0}", PolygonTestZero.GetPerimeter(rectangle));
            Console.WriteLine("Площадь четырехугольника:{0}", PolygonTestZero.GetArea(rectangle));
            Console.WriteLine("Периметр пятиугольника:{0}", String.Format("{0:0.00}",PolygonTestFirst.GetPerimeter(pentagon)));
            Console.WriteLine("Площадь пятиугольника:{0}", PolygonTestFirst.GetArea(pentagon));
            Console.ReadKey();
        }
    }
}
