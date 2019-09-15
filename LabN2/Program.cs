using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabN2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение по алгоритму:");
            Algorit(0.7391);
            Console.WriteLine("\nРешение по первому примеру:");
            Primer1(0.8);
            Console.WriteLine("\nРешение по второму примеру:");
            Primer2(1.5);
            Console.ReadKey();
        }

        static double e=0.00001, x, fxproizv, fx, D;

        static void Algorit(double z)
        {
            do
            {
                x = z;
                fxproizv = x - Math.Cos(x);
                D = 1 + Math.Sin(x);
                z = x - fxproizv / D;
                Console.WriteLine("Z = {0} и X = {1}", z, x);

            }
            while (Math.Abs(z - x)>e);

            x = z;
            fxproizv = x - Math.Cos(x);
            D = 1 + Math.Sin(x);
            fx = x * x / 2 - Math.Sin(x);
            if (D > 0)
            {
                Console.WriteLine("Минимум равен {0} в точке {1}", fx, x);
                return;
            }
            else if (D < 0)
            {
                Console.WriteLine("Максимум равен {0} в точке {1}", fx, x);
                return;
            }
        }

        static void Primer1(double z)
        {
            do
            {
                x = z;
                fxproizv = x * (2*x - 2)+Math.Pow((x-1),2);
                D = 2*(3*x -2);
                z = x - fxproizv / D;
                Console.WriteLine("Z = {0} и X = {1}", z, x);

            }
            while (Math.Abs(z - x)>e);

            x = z;
            fxproizv = x * (2 * x - 2) + Math.Pow((x - 1), 2);
            D = 2 * (3 * x - 2);
            fx = x*Math.Pow((x-1),2);
            if (D > 0)
            {
                Console.WriteLine("Минимум равен {0} в точке {1}", fx, x);
                return;
            }
            else if (D < 0)
            {
                Console.WriteLine("Максимум равен {0} в точке {1}", fx, x);
                return;
            }
        }

        static void Primer2(double z)
        {
            do
            {
                x = z;
                fxproizv = (-2*Math.Pow(x,2))/Math.Pow((Math.Pow(x,2)+1),2) + 1/(Math.Pow(x,2)+1);
                D = (2*x*(4*Math.Pow(x,2)/(Math.Pow(x,2)+1)-3))/Math.Pow(Math.Pow(x,2)+1,2);
                z = x - fxproizv / D;
                //Console.WriteLine("Z = {0} и X = {1}", z, x);

            }
            while (Math.Abs(z - x) > e);

            x = z;
            fxproizv = (-2 * Math.Pow(x, 2)) / Math.Pow((Math.Pow(x, 2) + 1), 2) + 1 / (Math.Pow(x, 2) + 1);
            D = (2 * x * (4 * Math.Pow(x, 2) / (Math.Pow(x, 2) + 1) - 3)) / Math.Pow(Math.Pow(x, 2) + 1, 2);
            fx = x / (Math.Pow(x,2)+1);
            if (D > 0)
            {
                Console.WriteLine("Минимум равен {0} в точке {1}", fx, x);
                return;
            }
            else if (D < 0)
            {
                Console.WriteLine("Максимум равен {0} в точке {1}", fx, x);
                return;
            }
        }
    }
}
