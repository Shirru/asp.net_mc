using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var isAgain = "y";
            while (isAgain.Equals("y"))
            {
                Console.WriteLine("Список реализованных задач: \n" +
                    "_____________________________________________________\n" +
                    "1.Вывести на экран сообщение «Hello World!»\n" +
                    "2.Вывести на экран три числа в порядке, обратном вводу\n" +
                    "3.Вывести на экран квадрат введенного числа\n" +
                    "4.Получить реверсную запись трехзначного числа\n" +
                    "5.Посчитать количество единичных битов числа\n" +
                    "6.Вывести на экран наибольшее из двух чисел\n" +
                    "7.Вывести на экран наибольшее из трех чисел\n" +
                    "8.Вывести название дня недели по его номеру\n" +
                    "9.Проверить, является ли четырехзначное число палиндромом\n" +
                    "10.Проверить, является ли четырехзначное число счастливым билетом\n" +
                    "11.Проверить, является ли двоичное представление числа палиндромом\n" +
                    "12.Решить квадратное уравнение\n" +
                    "37.Проверить, является ли натуральное число счастливым билетом\n" +
                    "38.Проверить, является ли натуральное число палиндромом\n" +
                    "39.Проверить, является ли натуральное число степенью двойки\n" +
                    "40.Вывести на экран произведение четных элементов заданной\n" +
                    "последовательности натуральных чисел\n" +
                    "41.Вывести на экран произведение двузначных элементов\n" +
                    "последовательности натуральных чисел, которые делятся на заданное число\n" +
                    "42.Найти количество простых членов последовательности\n" +
                    "43.Проверить, начинается ли каждый из членов последовательности\n" +
                    "с десятичной цифры, на которую оканчивается предыдущий\n" +
                    "44.Проверить, является ли последовательность пилообразной\n" +
                    "45.Проверить, является ли последовательность строго монотонной\n" +
                    "46.Вывести на экран n - ное число Фибоначчи\n" +
                    "47.Вывести на экран сумму чисел Фибоначчи до n - ного включительно\n" +
                    "48.Вывести на экран все числа Фибоначчи до n - ного включительно\n" +
                    "49.Проверить баланс круглых скобок в символьном выражении\n" +
                    "50.Вычислить экспоненту с заданной точностью\n" +
                    "_____________________________________________________\n\n");

                Console.WriteLine("Введите номер задачи или 0 для выхода: \n");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;

                if (number > 0 && number < 13 || number > 36 && number < 51)
                {
                    string method = "task_" + number;
                    while (isAgain.Equals("y"))
                    {
                        Type type = typeof(Program);
                        object o = Activator.CreateInstance(type);
                        System.Reflection.MethodInfo info = type.GetMethod(method);
                        info.Invoke(o, null);
                        Console.WriteLine("\nПовторить? y/n\n");
                        isAgain = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный номер \n");
                    Console.ReadLine();
                }

                isAgain = "y";
            }          
        }

        public static void task_1()
        {
            Console.WriteLine("Задача № 1. Вывести на экран сообщение «Hello World!» \n");
            Console.WriteLine("Hello, World!");
        }

        public static void task_2()
        {
            Console.WriteLine("Задача № 2.Вывести на экран три введенных с клавиатуры\n"+
                "числа в порядке, обратном их вводу.\n");
            Console.WriteLine("Введите три числа через пробел: ");
            var str = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(str[0]);
            int b = Convert.ToInt32(str[1]);
            int c = Convert.ToInt32(str[2]);
            Console.WriteLine("\nОтвет: " + c + " " + b + " " + a);
        }

        public static void task_3()
        {
            Console.WriteLine("Задача № 3. Дано натуральное число меньше 256.\n"+
                "Сформировать число, представляющее\nсобой его квадрат.\n");
            Console.WriteLine("Введите число, которое нужно возвести в квадрат: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет: " + a*a);
        }

        public static void task_4()
        {
            Console.WriteLine("Задача № 4. Сформировать число, представляющее\n"+
                "собой реверсную (обратную в порядке следования разрядов) запись\n"+
                "заданного трехзначного числа. Например, для числа 341 таким будет 143.\n");
            Console.WriteLine("Введите трехзначное число: ");
            var str = Console.ReadLine();
            Console.WriteLine("\nОтвет: " + str[2] + str[1] + str[0]);
        }

        public static void task_5()
        {
            Console.WriteLine("Задача № 5. Дано натуральное число меньше 16. Посчитать\n" +
                "количество его единичных битов. Например, если дано число 9, запись\n" +
                "которого в двоичной системе счисления равна 1001 (подстрочная цифра 2\n" +
                "справа от числа означает, что оно записано в двоичной системе счисления),\n" + 
                "то количество его единичных битов равно 2.\n");
            Console.WriteLine("Введите натуральное число меньше 16: ");
            string num = Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2);
            int count = 0;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == '1')
                    count++;
            }
            Console.WriteLine("\nОтвет: " + count);
        }

        public static void task_6()
        {
            Console.WriteLine("Задача № 6. Даны два числа. Вывести на экран то из них, которое больше.\n");
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nОтвет: " + (a > b ? a : b));
        }

        public static void task_7()
        {
            Console.WriteLine("Задача № 7. Даны три числа. Вывести на экран то из них, которое больше.\n");
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nОтвет: " + (a > b ? (a > c ? a : c) : (b > c ? b : c)));
        }

        public static void task_8()
        {
            Console.WriteLine("Задача № 8. Вывести название дня недели по его номеру.\n");
            Console.WriteLine("Введите номер: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("\nОтвет: Понедельник");
                    break;
                case 2:
                    Console.WriteLine("\nОтвет: Вторник");
                    break;
                case 3:
                    Console.WriteLine("\nОтвет: Среда");
                    break;
                case 4:
                    Console.WriteLine("\nОтвет: Четверг");
                    break;
                case 5:
                    Console.WriteLine("\nОтвет: Пятница");
                    break;
                case 6:
                    Console.WriteLine("\nОтвет: Суббота");
                    break;
                case 7:
                    Console.WriteLine("\nОтвет: Воскресенье");
                    break;
                default:
                    Console.WriteLine("\nНеверное число");
                    break;
            }
        }

        public static void task_9()
        {
            Console.WriteLine("Задача № 9. Дано четырехзначное число. Проверить, является ли оно палиндромом.\n" +
                "Примечание: палиндромом называется число, слово или текст, которые одинакового читаются слева\n" + 
                "направо и справа налево. Например, в нашем случае это числа 1441, 5555, 7117 и т. д.\n");
            Console.WriteLine("Введите четырехзначное число: ");
            string str = Console.ReadLine();

            Console.WriteLine("\nОтвет: " + (str[0] == str[3] ? (str[1] == str[2] ? "Да" : "Нет") : "Нет"));
        }

        public static void task_10()
        {
            Console.WriteLine("Задача № 10. Дано четырехзначное число. Проверить, является ли оно «счастливым билетом».\n" +
                "Примечание: счастливым билетом называется число, в котором: а) при четном количестве цифр в числе сумма\n" +
                "цифр его левой половины равна сумме цифр его правой половины; б) при нечетном количестве цифр – то же\n" +
                "самое, но с отбрасыванием серединной цифры. Например, рассмотрим число 1322. Его левая половина равна 13,\n" +
                "а правая – 22, и оно является счастливым билетом (т. к. 1 + 3 = 2 + 2). Аналогично: 1735 (1 + 7 = 3 + 5),\n" +
                "1111 (1 + 1 = 1 + 1) и т. д.\n");
            Console.WriteLine("Введите четырехзначное число: ");
            string str = Console.ReadLine();

            int a = Convert.ToInt32(str[0]) + Convert.ToInt32(str[1]);
            int b = Convert.ToInt32(str[2]) + Convert.ToInt32(str[3]);
            Console.WriteLine("\nОтвет: " + (a == b ? "Да" : "Нет"));
        }

        public static void task_11()
        {
            Console.WriteLine("Задача № 11. Дано число типа byte. Проверить, является ли палиндромом его двоичное\n" +
                "представление с учетом того, что сохранены старшие нули. Пример таких чисел: 102 (т. к. 102 = 0110 0110,\n" +
                "а это палиндром), 129 (129 = 1000 0001) и т. д.\n");
            Console.WriteLine("Введите число от 0 до 255: ");
            int num = Convert.ToInt32(Console.ReadLine());
            var binary = Convert.ToString(num, 2);

            if(binary.Length < 8)
            {
                while (binary.Length != 8)
                    binary = "0" + binary;
            }

            Console.WriteLine("\nОтвет: " + (binary[0] == binary[7] ? (binary[1] == binary[6] ? (binary[2] == binary[5] ?
                (binary[3] == binary[4] ? "Да" : "Нет" ) : "Нет") : "Нет") : "Нет"));

        }

        public static void task_12()
        {
            Console.WriteLine("Задача № 12. Даны вещественные числа a, b и c, причем a отлично от 0.\n" +
                "Решить квадратное уравнение ax2 + bx + c = 0 или сообщить о том, что действительных решений нет.\n");
            Console.WriteLine("Введите коэффициенты уравнения через пробел <a b c>, где a не равно 0: ");
            var coefs = Console.ReadLine().Split(' ');
            var a = Convert.ToDouble(coefs[0]);
            var b = Convert.ToDouble(coefs[1]);
            var c = Convert.ToDouble(coefs[2]);

            var disc = b * b - 4 * a * c;
            if(disc >= 0)
                if(disc > 0)
                {
                    Console.WriteLine("\nОтвет: x1 = " + (-b + Math.Sqrt(disc)) / (2 * a) + " x2 = " + 
                        (-b - Math.Sqrt(disc)) / (2 * a)); 
                }
                else
                {
                    Console.WriteLine("\nОтвет: x = " + (-b / (2 * a)));
                }
            else
            {
                Console.WriteLine("\nОтвет: нет действительных решений");
            }

        }

        public static void task_37()
        {
            Console.WriteLine("Задача № 37. Дано натуральное число n. Проверить, является ли оно счастливым билетом.\n");
            Console.WriteLine("Введите число: ");
            var n = Console.ReadLine();
            int left = 0;
            int right = 0;

            for(int i = 0; i < n.Length / 2; i++)
            {
                left += Convert.ToInt32(n[i]);
            }

            int start = n.Length % 2 == 0 ? n.Length / 2 : n.Length / 2 + 1;
            for (int i = start; i < n.Length; i++)
            {
                right += Convert.ToInt32(n[i]);
            }

            Console.WriteLine("\nОтвет: " + (left == right ? "Да" : "Нет"));
        }

        public static void task_38()
        {
            Console.WriteLine("Задача № 38. Дано натуральное число n. Проверить, представляет\n" +
                "ли собой палиндром его десятичная запись.\n");
            Console.WriteLine("Введите число: ");
            var n = Console.ReadLine();
            string leftReverse = "";
            bool isPol = true;

            for (int i = n.Length / 2 - 1; i >= 0; i--)
            {
                leftReverse += n[i];
            }

            int start = n.Length % 2 == 0 ? n.Length / 2 : n.Length / 2 + 1;
            for (int i = start, j = 0; i < n.Length && isPol; i++, j++)
            {
                isPol = leftReverse[j] == n[i] ? true : false;
            }

            Console.WriteLine("\nОтвет: " + (isPol ? "Да" : "Нет"));
        }

        public static void task_39()
        {
            Console.WriteLine("Задача № 39. Дано натуральное число n. Проверить, представляет\n" +
                "ли оно собой натуральную степень числа 2.\n");
            Console.WriteLine("Введите число: ");
            var n = Convert.ToInt32(Console.ReadLine());
            bool isPow = false;

            while (n != 1)
            {
                    isPow = n % 2 == 0 ? true : false;
                    n = n / 2;
            }

            Console.WriteLine("\nОтвет: " + (isPow ? "Да" : "Нет"));
        }

        public static void task_40()
        {
            Console.WriteLine("Задача № 40. Дана последовательность натуральных чисел,\n" +
                "ограниченная вводом нуля. Вывести на экран произведение четных элементов\n" +
                "этой последовательности. При этом ноль не считается членом последовательности.\n");

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности): ");

            int res = 1;
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                if(num % 2 == 0)
                    res *= num;
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nОтвет: " + res);
        }

        public static void task_41()
        {
            Console.WriteLine("Задача № 41.  Дано натуральное число n, а затем последовательность\n" +
                "натуральных чисел, ограниченная вводом нуля. Вывести на экран произведение\n" +
                "двузначных элементов этой последовательности, которые делятся на n.\n");

            Console.WriteLine("Введите натуральное число n: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности): ");
            int res = 1;
            int elem = Convert.ToInt32(Console.ReadLine());
            while (elem != 0)
            {
                if (elem % num == 0 && elem > 9 && elem < 100)
                    res *= elem;
                elem = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nОтвет: " + (res == 1 ? "Нет двузначных элементов" : res.ToString()));
        }

        public static void task_42()
        {
            Console.WriteLine("Задача № 42. Дана последовательность натуральных чисел,\n" +
                "ограниченная вводом нуля. Вывести на экран количество простых членов этой\n" +
                "последовательности.\n");

            int count = 0;

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности): ");
            int elem = Convert.ToInt32(Console.ReadLine());
            while (elem != 0)
            {
                int multi_count = 0;
                for(int i = 2; i < elem && multi_count == 0; i++)
                {
                    if (elem % i == 0)
                        multi_count++;
                }
                if (multi_count == 0)
                    count++;
                elem = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nОтвет: " + count);
        }

        public static void task_43()
        {
            Console.WriteLine("Задача № 43. Дана последовательность натуральных чисел,\n" +
                "ограниченная вводом нуля. Проверить, начинается ли каждый из ее членов\n" +
                "(со второго) с десятичной цифры, на которую оканчивается предыдущий.\n" +
                "Например, таковой последовательностью будет являться 14 47 712 2179 9\n" +
                "9 93 0 (также сохранен ограничивающий ноль).\n");

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности): ");
            string elem = Console.ReadLine();

            bool isSame = true;
            while (elem != "0")
            {   
                string next = Console.ReadLine();
                if (!(elem[elem.Length - 1] == next[0]) && next != "0")
                    isSame = false;
                elem = next;                   
            }

            Console.WriteLine("\nОтвет: " + (isSame? "Да" : "Нет"));
        }

        public static void task_44()
        {
            Console.WriteLine("Задача № 44. Дана последовательность из трех и более\n"+
                "натуральных чисел, ограниченная вводом нуля. Проверить, является ли\n"+
                "эта последовательность пилообразной.\n"+
                "Примечание: пилообразной называется последовательность чисел, в\n"+
                "которой каждый член, имеющий соседние члены, меньше или больше их.\n");

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности), не менее 3х элементов : ");
            int left = Convert.ToInt32(Console.ReadLine());
            int middle = Convert.ToInt32(Console.ReadLine());
            int right = Convert.ToInt32(Console.ReadLine());

            bool isSaw = true;
            while (right != 0)
            {
                if ((left - middle) * (right - middle) <= 0)
                    isSaw = false;
                left = middle;
                middle = right;
                right = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nОтвет: " + (isSaw ? "Да" : "Нет"));
        }

        public static void task_45()
        {
            Console.WriteLine("Задача № 45. Дана последовательность натуральных чисел,\n"+
                "ограниченная вводом нуля. Проверить, является ли эта последовательность\n"+
                "строго монотонной.\n");

            Console.WriteLine("Введите последовательность (после ввода элемента последовательности\n" +
                "нажимайте enter, 0 - конец последовательности): ");
            int elem = Convert.ToInt32(Console.ReadLine());
            int next = Convert.ToInt32(Console.ReadLine());

            bool isMon = true;
            int diff = elem - next; 

            while (next != 0)
            {
                if (!(diff * (elem - next) > 0))
                    isMon = false;
                elem = next;
                next = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nОтвет: " + (isMon ? "Да" : "Нет"));
        }

        public static void task_46()
        {
            Console.WriteLine("Задача № 46.  Дано натуральное n (которое также может быть равно 0).\n"+
                "Вывести на экран n-ное число Фибоначчи.\n");

            Console.WriteLine("Введите номер числа Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long f0 = 0;
            long f1 = 1;
            long f2 = n;

            if(n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    f2 = f1 + f0;
                    f0 = f1;
                    f1 = f2;
                }
            }

            Console.WriteLine("\nОтвет: " + f2);
        }

        public static void task_47()
        {
            Console.WriteLine("Задача № 47. Дано натуральное n (которое также может быть равно 0).\n"+
                "Вывести на экран сумму чисел Фибоначчи до n-ного включительно. Например, при n = 3\n"+
                "нам необходимо получить сумму 0-го, 1-го, 2-го и 3-го членов последовательности.\n");

            Console.WriteLine("Введите номер числа Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long f0 = 0;
            long f1 = 1;
            long sum = 1;
            long f2 = 0; 

            if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    f2 = f1 + f0;
                    f0 = f1;
                    f1 = f2;
                    sum += f2;
                }
            }
            else
            {
                sum = n;
            }

            Console.WriteLine("\nОтвет: " + sum);
        }

        public static void task_48()
        {
            Console.WriteLine("Задача № 48. Дано натуральное n (которое также может быть равно 0).\n" + 
                "Вывести на экран все числа Фибоначчи до n-ного включительно.\n");

            Console.WriteLine("Введите номер числа Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());


            long f0 = 0;
            long f1 = 1;
            long f2 = 0;

            if (n > 1)
            {
                Console.Write("Ответ: " + f0 + " " + f1 + " ");
                for (int i = 2; i <= n; i++)
                {
                    f2 = f1 + f0;
                    f0 = f1;
                    f1 = f2;
                    Console.Write(f2 + " ");
                }
            }
            else
            {
                Console.Write((n == 0 ? "Ответ: 0 " : "0 1 "));
            }

        }

        public static void task_49()
        {
            Console.WriteLine("Задача № 49. Дана последовательность символов длины n (n >= 1).\n"+
                "Проверить баланс круглых скобок в этом выражении. Например, при вводе\n"+
                "выражения (())() программа должна сообщить о правильности расстановки\n"+
                "скобок, а при вводе выражения ((()) – о неправильности.\n");

            Console.WriteLine("Введите выражение: ");
            string exp = Console.ReadLine();
            int count = 0;

            for(int i = 0; i < exp.Length; i++)
            {
                if (exp[i].Equals('(')) count++;
                if (exp[i].Equals(')')) count--;
            }

            Console.WriteLine("\nОтвет: " + (count == 0 ? "Все ок" : "Не ок"));
        }

        public static void task_50()
        {
            Console.WriteLine("Задача № 50. Дано действительное число x. Вычислить значение\n" +
                "экспоненциальной функции (то есть, показательной функции e^x, где e – \n" +
                "математическая константа, ) в точке x с заданной точностью eps с помощью\n" +
                "ряда Тейлора.\n");

            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение точности: ");
            double eps = Convert.ToDouble(Console.ReadLine());

            double add = 1;
            double sum = 0;
            double denom = 1;
            double numer = 1;

            for(int i = 1; Math.Abs(add) >= eps; i++)
            {
                sum += add;
                numer *= x;
                denom *= i;
                add = numer / denom;
            }

            Console.WriteLine("Ответ: " + sum);
        }
    }
}
