using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_Vasilev
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("Введите размер дневной выручки продавца");
            v = Convert.ToInt32(Console.ReadLine());
            int min = 300;
            if (500* v <min)
                Console.WriteLine("Выручка продавца = {0}",min);
            else
                if (v <= 10000)
                Console.WriteLine("Выручка продавца = {0}", 500 * v);
            else
                Console.WriteLine("Выручка продавца = {0}", 500 + ((v - 10000) * 0.1));
            Console.ReadKey();
        }
    }
}
