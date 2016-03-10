using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача нахождения максимума из последовательности
            int max = 1;
            Console.WriteLine("Входные данные состоят из нескольких тестов (не более 10). Каждый тест представляет собой строку, в которой записано целое число n (1 <= n <= 99 999). В последней строке входных данных записано число 0.");
            for (int i = 0; i < 10; i++)
            {
                max = findMax();
                if (max == -1) break;
                if (max == -2) Console.WriteLine("Некорректный ввод");
                else Console.WriteLine("Ответ: " + max);
            }       

        }

        public static int findMax()
        {
            int max = 1;
            var n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                if (n < 0 || n > 99999)
                    return -2;
                n++;
                int[] seq = new int[n];
                seq[0] = 0;
                seq[1] = 1;
                for (int j = 1; j < n/2; j++)
                {
                    seq[j*2] = seq[j];
                    if ((2*j + 1) >= n)
                    {
                        if (seq[j*2] >= max) max = seq[j*2];
                        break;
                    }
                    else
                    {
                        seq[2*j + 1] = seq[j] + seq[j + 1];
                        if (seq[j*2] >= max && seq[j*2] >= seq[2*j + 1]) max = seq[j*2];
                        else if (seq[2*j + 1] >= max && seq[j*2 + 1] >= seq[2*j]) max = seq[2*j + 1];
                    }

                }
                return max;
            }
            else return -1;
        }
    }
}
