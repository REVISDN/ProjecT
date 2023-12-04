using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            double x;
            if (a > b)
            {
                x = a * b + 1;
            }
            else if (a == b)
            {
                x = 25;
            }
            else
            {
                x = (a - 5) / b;
                Console.WriteLine("xoy");
            }

            Console.WriteLine("Значение X равно " + x);
        }
    }
}
