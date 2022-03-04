using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_59
{
    internal class Program
    {
        double func(double px, double py, double x1, double y1, double x2, double y2)
        {
            double a = Math.Sqrt(Math.Pow((px - x1), 2) + Math.Pow((py - y1), 2));
            double b = Math.Sqrt(Math.Pow((px - x2), 2) + Math.Pow((py - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double p = (a + b + c)/2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return 2 * s/c;
        }
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, px, py;
            Console.WriteLine($"Введите x1: ");
        }
    }
}
