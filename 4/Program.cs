using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if ((N >= 0) & (N <= 3))
            {
                double SUM = double.Parse(Console.ReadLine());
                if (N == 1)
                {
                    double svkl= SUM*1.07;
                    double res = svkl - SUM;
                    Console.WriteLine(res+" Руб");
                }
                if (N == 2)
                {
                    Console.WriteLine(SUM * (Math.Pow(1.08, 3)) - SUM + " Руб");
                }
                if(N == 3)
                {
                    Console.WriteLine(SUM * (Math.Pow(1.1, 5)) - SUM + " Руб");
                }
            }
            else
            {
                Console.WriteLine("N только в диапазоне от 1 до 3");
            }
            Console.ReadLine();
        }
    }
}
