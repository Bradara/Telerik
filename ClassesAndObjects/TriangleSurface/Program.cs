namespace TriangleSurface
{
    using System;

    class TriangleSurface
    {
        class Triangle
        {
            public double surface { get; }
            public int Angle { get; }
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Side3 { get; set; }
            public double Altitude { get; set; }

           public Triangle(double side, double altitude)
            {
                Side1 = side;
                Altitude = altitude;
                surface = CalcSurface(Side1, Altitude);
            }
            public Triangle(double side, double side2, double side3 )
            {
                Side1 = side;
                Side2 = side2;
                Side3 = side3;
                surface = CalcSurface(Side1, Side2, Side3);
            }

            public Triangle(double side1, double side2, int angle)
            {
                Side1 = side1;
                Side2 = side2;
                Angle = angle;
                surface = CalcSurface(Side1, Side2, Angle);
            }

            private double CalcSurface(double side1, double side2, int angle)
            {
                return side1 * (side2 / 2)*Math.Sin(Math.PI/180*angle);
            }

            private double CalcSurface(double side1, double side2, double side3)
            {
                var halfPer = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(halfPer * (halfPer - Side1) * (halfPer - Side2) * (halfPer - Side3));
            }

            private double CalcSurface(double side, double altitude)
            {
                return side * altitude / 2;
            }
        }

        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            int angle = int.Parse(Console.ReadLine());

            var tr = new Triangle(side1, side2, angle);
            Console.WriteLine("{0:f2}", tr.surface);
            Console.WriteLine(Math.Sin(35));
        }
    }
}
