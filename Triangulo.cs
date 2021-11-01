

using System;

namespace Aula21_Classes
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double areaTriangulo = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return areaTriangulo;

        }
    }
}
