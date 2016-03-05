using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int half = 0;
            int max = 0;
            int res = -100;

            Console.WriteLine("Введите количество камней: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Введите веса камней через пробел: ");
            var str = Console.ReadLine().Split(' ');

            for(int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(str[i]);
                sum += array[i];
            }

            half = sum / 2;
            Array.Sort(array);
            max = array[size - 1];

            if(max <= half)
            {
                for(int i = size - 2; i >= 0; i--)
                {
                    if ((max + array[i]) <= half)
                        max += array[i];
                }             
            }

            res = Math.Abs(sum - max - max);

            Console.WriteLine("\nОтвет: " + res);

            Console.ReadLine();
        }
    }
}
