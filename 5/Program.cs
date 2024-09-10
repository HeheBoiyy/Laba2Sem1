using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double narush = speed - 90;
            if (narush > 0)
            {
                if (narush >= 20 & narush<=39)
                {
                    Console.WriteLine("Штраф 500 Руб");

                }

                if (narush >= 40 & narush <= 59)
                {
                    Console.WriteLine("Штраф 1500 Руб");

                }

                if (narush >= 60 & narush <= 79)
                {
                    Console.WriteLine("Штраф 2500 Руб или лишение прав на 4 месяца");

                }

                if (narush >=80)
                {
                    Console.WriteLine("Штраф 5000 Руб или лишение прав на полгода");

                }
            }
            else
            {
                Console.WriteLine("Скорость автомобиля допустима на данном участке");
            }
            Console.ReadLine();
        }   
    }
}
