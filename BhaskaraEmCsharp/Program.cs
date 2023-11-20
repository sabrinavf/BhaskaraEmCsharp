using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            double R1, R2, Delta;

            string[] vet = (Console.ReadLine()).Split(' ');
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);


            Delta = Math.Pow(B, 2.0) - 4 * A * C; // calculo delta 

            if (A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");

            }
            else
            {
                // calculo das raizes
                R1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));

            }



        }
    }
}
