using System;

namespace Aula21_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           


            //-----------------------------------Udemy-------------------------------------------------------------------------------

            //Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas válidas).
            //Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
            //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte(fórmula de Heron):

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine(" Digite as medidas do triango X\n");
            Console.Write("Xa: ");
            x.A = double.Parse(Console.ReadLine());
            Console.Write("Xb: ");
            x.B = double.Parse(Console.ReadLine());
            Console.Write("Xc: ");
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine(" \nDigite as medidas do triango Y\n");
            Console.Write("Ya: ");
            y.A = double.Parse(Console.ReadLine());
            Console.Write("Yb: ");
            y.B = double.Parse(Console.ReadLine());
            Console.Write("Yc: ");
            y.C = double.Parse(Console.ReadLine());

            double areaTrianguloX = x.Area();
            double areaTrianguloY = y.Area();

            Console.WriteLine($"Area triangulo X {areaTrianguloX}.\nArea triangulo Y {areaTrianguloY}");

            if (areaTrianguloX > areaTrianguloY)
            {
                Console.WriteLine("\nA área do trinado X é maior");
            }
            else
            {
                Console.WriteLine("\nA área do triangulo Y é maior");
            }

        }


    }
}
