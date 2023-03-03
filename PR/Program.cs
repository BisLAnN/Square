using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Длина стороны квадрата: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a <= 0) Console.WriteLine("Длина стороны не может быть меньше либо равна нулю!");

                else
                {
                    int P = a * 4;
                    int S = a * a;
                    Console.WriteLine("Периметр квадрата: " + P);
                    Console.WriteLine("Площадь квадрата: " + S);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.Read();
        }
    }
}
