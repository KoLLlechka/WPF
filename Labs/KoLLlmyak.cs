using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    sealed class KoLLlmyak : Numbers
    {
        public KoLLlmyak() : base()
        {
        }

        public KoLLlmyak(double x, double y, double z) : base(x, y, z)
        {
        }

        public bool IsNotTriangle()
        {
            return (x + y < z || x + z < y || z + y < x);
        }

        public double Perimeter()
        {
            return x + y + z;
        }

        public double HalfPerimeter()
        {
            return Perimeter()/2.0;
        }

        public double Square()
        {
            double hper = HalfPerimeter();
            return Math.Sqrt(hper * (hper - x) * (hper - y) * (hper - z));
        }

        public string Triangle()
        {
            if (IsNotTriangle())
                return "Треугольника с такими сторонами не существует";
            else
            {
                return "Периметр треугольника равен: " + Perimeter().ToString() + "\n" +
                    "Полупериметр треугольника равен: " + HalfPerimeter().ToString() + "\n" +
                    "Площадь треугольника равна: " + Square().ToString();
            }
        }
    }
}
