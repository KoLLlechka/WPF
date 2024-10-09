using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class Numbers
    {
        protected double x, y, z;

        public Numbers()
        {
            Random random = new Random();
            x = random.Next(1000) / Math.Pow(10, random.Next(3));
            y = random.Next(1000) / Math.Pow(10, random.Next(3));
            z = random.Next(1000) / Math.Pow(10, random.Next(3));
        }

        public Numbers(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Numbers(Numbers n) // конструктор копирования
        {
            x = n.x;
            y = n.y;
            z = n.z;
        }

        public void ToInt()
        {
            x = (int)x;
            y = (int)y;
            z = (int)z;
        }

        public override string ToString()
        {
            return $"Стороны: {x}; {y}; {z}";
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public double Z
        {
            get { return z; }
        }
    }
}
