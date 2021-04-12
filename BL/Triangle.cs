using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort.BL
{
    class Triangle
    {
        private string name { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Triangle(float A,float B, float C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) *(p - b) * (p - c));
        }
    }
}
