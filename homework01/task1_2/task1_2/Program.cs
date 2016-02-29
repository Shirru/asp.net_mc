using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            string res = "";

            for (int i = 0; i < size; i++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < index; j++)
                {
                    sum += j;
                    if(index <= sum)
                    {
                        res += index == sum ? "1 " : "0 ";
                        j = index;
                    }

                }
                sum = 1;
            }

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
