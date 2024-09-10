using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a + c > b & a + b > c & b + c > a)
            {



                if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2) || ((Math.Pow(b, 2) + Math.Pow(c, 2)) == Math.Pow(a, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2)) == Math.Pow(b, 2)) 
                {
                    Console.WriteLine("Прямоугольный треугольник");


                }
                else
                {
                    double cos = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
                    Console.WriteLine(cos * 180 / Math.PI);
               
                }
                
            }
            Console.ReadLine();

        }
    }
}
