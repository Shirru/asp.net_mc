using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сумма от 1 до n
            Console.WriteLine("Введите n <= 10000");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(n) <= 10000)
            {
                if(n > 0)
                    Console.WriteLine("Ответ: " + (n*(n + 1))/2);
                else
                    Console.WriteLine("Ответ: " + (-(n * (n - 1)) / 2 + 1));
            }
            else Console.WriteLine("Некорректный ввод");
            Console.ReadLine();
        }
    }
}
