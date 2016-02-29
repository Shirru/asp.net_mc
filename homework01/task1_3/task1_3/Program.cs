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
            int num_of_groups = Convert.ToInt32(Console.ReadLine());
            int[] groups = new int[num_of_groups];
            int res = 0;

            var str = Console.ReadLine().Split(' ');

            for(int i = 0; i < num_of_groups; i++)
            {
                groups[i] = Convert.ToInt32(str[i]);
            }

            num_of_groups = num_of_groups / 2 + 1;
            Array.Sort(groups);

            for(int i = 0; i < num_of_groups; i++)
            {
                res += groups[i] / 2 + 1;
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
