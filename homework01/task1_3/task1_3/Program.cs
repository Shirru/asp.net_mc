using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRight = false;
            int num_of_groups = 0;
            while (!isRight) {
                Console.WriteLine("Введите нечетное число K — количество групп избирателей (1 <= K <= 101): ");
                num_of_groups = Convert.ToInt32(Console.ReadLine());
                if (num_of_groups%2 == 0 || num_of_groups < 1 || num_of_groups > 101)
                    Console.WriteLine("Некорректное число");
                else isRight = true;
            }
            
            int[] groups = new int[num_of_groups];
            int res = 0;
            isRight = false;

            while (!isRight)
            {
                Console.WriteLine(
                    "Введите через пробел K нечётных чисел, которые задают количество избирателей в группах (население острова не превосходит 9999 человек): ");
                var str = Console.ReadLine().Split(' ');

                int sum = 0;
                for (int i = 0; i < num_of_groups; i++)
                {
                    groups[i] = Convert.ToInt32(str[i]);
                    sum += groups[i];
                    if (groups[i]%2 == 0 || sum > 9999)
                    {
                        isRight = false;
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    else isRight = true;
                }
            }

            num_of_groups = num_of_groups/2 + 1;
            Array.Sort(groups);

            for (int i = 0; i < num_of_groups; i++)
            {
               res += groups[i]/2 + 1;
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
