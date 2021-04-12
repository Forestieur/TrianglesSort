using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort.BL
{
    class Triangle : IComparable<Triangle>
    {
        private string name { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double area { get; set; }


        public Triangle(string Name, float A,float B, float C)
        {
            name = Name;
            a = A;
            b = B;
            c = C;
            area = AreaCalculate();
        }

        public string Name { get { return name; } }
        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }
        public double Area { get { return area; } }
       
        public double AreaCalculate()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) *(p - b) * (p - c));
        }

        public int CompareTo(Triangle other)
        {
            if (other == null)
                return 1;
            else
                return this.Area.CompareTo(other.Area);
        }
    }
}
