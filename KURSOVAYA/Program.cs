using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewtonMethod;
using System.Diagnostics;

namespace KURSOVAYA
{
    class Program
    {
        static void Print(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("X[" + (i + 1) + "] = " + array[i] + " ");
            }
            Console.Write("\nF(X) = " + array[array.Length - 1]);
            Console.WriteLine("\n");
        }

        static void Main()
        {
            Func<Vector, double> e1 = a => a.X[0] * a.X[1] - 8 * a.X[0] - 4 * a.X[2] + 10;
            Func<Vector, double> e2 = a => 2 * a.X[0] - 3 * a.X[1] + a.X[2] * a.X[2] - 4;
            Func<Vector, double> e3 = a => 3 * a.X[0] - a.X[1] * a.X[2] - 3 * a.X[2] - 19;

            Func<Vector, double> r1 = a => a.X[0] * a.X[0] - 2 * a.X[1] * a.X[1] - a.X[0] * a.X[1] + 2 * a.X[0] - a.X[1] + 1;
            Func<Vector, double> r2 = a => 2 * a.X[0] * a.X[0] - a.X[1] * a.X[1] + a.X[0] * a.X[1] + 3 * a.X[1] - 5;

            Func<Vector, double> s1 = a => 3 * a.X[0] * a.X[0] + a.X[0] * a.X[1] - 2 * a.X[1] * a.X[1];
            Func<Vector, double> s2 = a => 2 * a.X[0] * a.X[0] - 3 * a.X[0] * a.X[1] + a.X[1] * a.X[1] + 1;

            Func<Vector, double> y1 = a => a.X[0] * a.X[0] + a.X[0] - a.X[1] * a.X[1] - 0.15;
            Func<Vector, double> y2 = a => a.X[0] * a.X[0] - a.X[1] + a.X[1] * a.X[1] + 0.17;


            var c = Newton.SolveNewthon(e1, e2, e3);
            var d = Newton.IncompleteForecast(e1, e2, e3);
            var f = Newton.СompleteForecast(e1, e2, e3);

            Print(c);
            Print(d);
            Print(f);
            Console.WriteLine();

            var c2 = Newton.SolveNewthon(r1, r2);
            var d2 = Newton.IncompleteForecast(r1, r2);
            var f2 = Newton.СompleteForecast(r1, r2);

            Print(c2);
            Print(d2);
            Print(f2);
            Console.WriteLine();

            var c3 = Newton.SolveNewthon(s1, s2);
            var d3 = Newton.IncompleteForecast(s1, s2);
            var f3 = Newton.СompleteForecast(s1, s2);

            Print(c3);
            Print(d3);
            Print(f3);
            Console.WriteLine();

            var c4 = Newton.SolveNewthon(y1, y2);
            var d4 = Newton.IncompleteForecast(y1, y2);
            var f4 = Newton.СompleteForecast(y1, y2);

            Print(c4);
            Print(d4);
            Print(f4);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
