using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача про Гарри и Ларри
            Console.WriteLine("Введите 2 числа — количество банок, простреленных Гарри и Ларри соответственно (через пробел):");
            var cans = Console.ReadLine().Split(' ');
            var all = Convert.ToInt32(cans[0]) + Convert.ToInt32(cans[1]) - 1;
            Console.WriteLine("Ответ: {0} {1}",(all - Convert.ToInt32(cans[0])),(all - Convert.ToInt32(cans[1])));
            Console.ReadLine();
        }
    }
}
