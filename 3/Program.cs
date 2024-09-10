using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if ((N / 2 * 20) > 480 || ((N - 1) / 2 * 20) > 480)
            {
                Console.WriteLine("Ждать смысла нет");
            }
            else
            {
                if (N % 2 == 0)
                {
                    int res = N / 2 * 20;
                    Console.WriteLine(res + " Минут");

                }
                else
                {
                    int res = ((N - 1) / 2) * 20;
                    Console.WriteLine(res + " Минут");

                }
            }
            Console.ReadLine();
        }
    }
}
