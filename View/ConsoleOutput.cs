using System;
using System.Collections.Generic;

using TrianglesSort.BL;

namespace TrianglesSort.View
{
    class ConsoleOutput
    {
        private List<Triangle> triangles = new List<Triangle>();

        public ConsoleOutput()
        {
            Continue();
            Show();
        }

        private Triangle Input()
        {
            Console.WriteLine("Введите Имя и стороны треугольника через запятую");
            string parameters = Console.ReadLine();

            string[] destinationParametrs = parameters.Replace("\t", "").Replace(" ", "").Split(new char[] { ',' }, 4);
            if (!float.TryParse(destinationParametrs[1], out float a))
            {
                throw new ArgumentException("Первая сторона не являются числом");
            }
            if (!float.TryParse(destinationParametrs[2], out float b))
            {
                throw new ArgumentException("Вторая сторона Третья сторона не являются числом");
            }
            if (!float.TryParse(destinationParametrs[3], out float c))
            {
                throw new ArgumentException("Вторая сторона Третья сторона не являются числом");
            }

            return new Triangle(destinationParametrs[0],a, b,c);
        }

        private void Continue()
        {
            triangles.Add(Input());
            
            Console.WriteLine("Продолжить?");
            
            string check = Console.ReadLine();
            if (check.ToLower() == "y" || check.ToLower() == "yes")
            {
                Continue();
            }
            else return;
        }

        private void Show()
        {
            triangles.Sort();
            triangles.Reverse();
            foreach (Triangle t in triangles)
            {
                if (t.Area > 0)
                {
                    Console.WriteLine($"[{t.Name}]: {Math.Round(t.Area,2)} cm");
                }
                else
                {
                    Console.WriteLine($"[{t.Name}]: такой треугольник не может существовать");
                }
            }
            Console.ReadLine();
        }
    }
}
