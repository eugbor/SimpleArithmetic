using System;

namespace SimpleArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислите 1/2 + 1/4.Ответ: 0.75.
            //
            //float a = 1;
            //float b = 2;
            //float c = 4;
            //float result = a / b + a / c;
            //Console.WriteLine("{0:0.##}", result);

            //Вычислите значение выражения (a+4b)(a−3b)+a^2 при a=2 и b=3. Ответ: -94.
            //
            //double a = 2;
            //double b = 3;
            //double result = (a + 4*b)*(a - 3*b) + Math.Pow(a, 2);
            //Console.WriteLine("{0:0}", result);

            //Вычислите |x|+x^5, если x=−2.
            //
            //double x = -2;
            //double result = Math.Abs(x) + Math.Pow(x, 5);
            //Console.WriteLine(result);

            //Вычислите значение выражения (x+1)2+3(x+1) при а) x=1.7; б) x=3. Ответ: а) 15.39 б) 28.
            //
            //double x = 1.7;
            //double result = Math.Pow((x + 1), 2) + 3 * (x + 1);
            //Console.WriteLine(result);

            //Вычислите значение выражения (|x−5|−sinx)/3+ Math.Sqrt(x^2+2014)*cos2x−3 при x=−2.34. Ответ: -1.76911.
            //
            //double x = -2.34;
            //double result = (Math.Abs(x - 5) - Math.Sin(x)) / 3 + Math.Sqrt(Math.Pow(x, 2) + 2014) * Math.Cos(2 * x) - 3;
            //Console.WriteLine("{0:0.#####}", result);

            //Вычислите значение выражения e^(x−2)+|sin(x)|−x^10*cos1/x при x=3.6.
            //
            //double x = 3.6;
            //double result = Math.Exp(x - 2) + Math.Abs(Math.Sin(x)) - Math.Pow(x, 10) * Math.Cos(1 / x);
            //Console.WriteLine(result);

            //Вычислите значение выражения Math.Pow((Math.Pow(x, 2) + 2), 1/5) - (Math.Pow(b, 2)*Math.Pow(Math.Sin(x + a), 3))/x
            //при a=0.1, b=0.2 и x=1
            //
            //double a = 0.1;
            //double b = 0.2;
            //double x = 1;
            //double result = Math.Pow((Math.Pow(x, 2) + 2), 1/5) - (Math.Pow(b, 2)*Math.Pow(Math.Sin(x + a), 3))/x;
            //Console.WriteLine(result);

            //Пользователь вводит два числа. Найдите сумму и произведение данных чисел.
            //
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int sum = a + b;
            //int mult = a * b;
            //Console.WriteLine("Sum: {0}, Mult: {1}", sum, mult);

            //Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа.
            //
            //double a = double.Parse(Console.ReadLine());
            //int square = Convert.ToInt32(Math.Pow(a, 2));
            //int cube = Convert.ToInt32(Math.Pow(a, 3));
            //Console.WriteLine("Square: {0}, Cube: {1}", square, cube);

            //Пользователь вводит три числа. Увеличьте первое число в два раза, второе числа уменьшите на 3,
            //третье число возведите в квадрат и затем найдите сумму новых трех чисел.
            //
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //int result = (a * 2) + (b - 3) + Convert.ToInt32(Math.Pow(c, 2));
            //Console.WriteLine(result);

            //Пользователь вводит три числа. Найдите среднее арифметическое этих чисел,
            //а также разность удвоенной суммы первого и третьего чисел и утроенного второго числа.
            //
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int average = (a + b + c)/3;
            //int diff = ((a + c)*2) - b*3;
            //Console.WriteLine("Average: {0}, Diff: {1}", average, diff);

            //Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата.
            //
            //double a = double.Parse(Console.ReadLine());
            //int perimeter = Convert.ToInt32(4 * a);
            //int area = Convert.ToInt32(Math.Pow(a, 2));
            //Console.WriteLine("Perimeter: {0}, Area: {1}", perimeter, area);

            //Пользователь вводит цены 1 кг конфет и 1 кг печенья. Найдите стоимость:
            //а) одной покупки из 300 г конфет и 400 г печенья;
            //б)трех покупок, каждая из 2 кг печенья и 1 кг 800 г конфет.
            //
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double purchase = a*0.3 + b*0.4;
            //double threePurchases = (a * 1.8 + b * 2) * 3;
            //Console.WriteLine("Purchase: {0}, ThreePurchases: {1}", purchase, threePurchases);

            // Пользователь вводит время в минутах и расстояние в километрах. Найдите скорость в м/c.
            //
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double t = a * 60;
            //double s = b * 1000;
            //double result = s / t;
            //Console.WriteLine("Speed: {0:0.##} m/s", result);

            //Пользователь вводит количество дней, указывает процент скидки и вводит сумму.
            //Рассчитать прибыль, если за каждый день сумма увеличивается на 3 $
            //и затем применяется скидка, то есть итоговая сумма еще увеличивается на данное число процентов.
            //
            //double days = int.Parse(Console.ReadLine());
            //double percent = int.Parse(Console.ReadLine());
            //double sum = int.Parse(Console.ReadLine());
            //double result = ((sum + 3)*days*percent/100);
            //Console.WriteLine(result);

            //Дано число. Если оно больше 3, то увеличить число на 10, иначе уменьшить на 10.
            //
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a > 3)
            //{
            //    a += 10;
            //}
            //else
            //{
            //    a -= 10;
            //}
            //Console.WriteLine(a);

            //Пользователь вводит номер месяца. Вывести название поры года (весна, лето и т.д.).
            //
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (!(a > 0 && a < 13))
            //{
            //    Console.WriteLine("wrong number");
            //    Console.ReadLine();
            //    return;
            //}
            //if (!(a < 3))
            //{
            //    if (!(a < 6))
            //    {
            //        if (!(a < 9))
            //        {
            //            if (!(a == 12) && a < 12)
            //            {
            //                Console.WriteLine("autumn");
            //            }
            //            else
            //            {
            //                Console.WriteLine("winter");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("summer");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("spring");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("winter");
            //}

            //Даны три числа. Найдите те два из них, сумма которых наибольшая.
            //
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (!(a + b > b + c && a + b > a + c))
            //{
            //    if (!(b + c > a + c))
            //    {
            //        Console.WriteLine(a + c);
            //        Console.ReadLine();
            //        return;
            //    }
            //    Console.WriteLine(b + c);
            //}
            //else
            //{
            //    Console.WriteLine(a + b);
            //}

            //Дано четырехзначное число. Верно ли, что цифр в нем расположены по убыванию?
            //Например, 4311 - нет, 4321 - да, 5542 - нет, 5631 - нет, 9871 - да.
            //
            //string str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (!(str[i] > str[j]))
            //        {
            //            Console.WriteLine("No");
            //            Console.ReadLine();
            //            return;
            //        }
            //    }
            //}
            //Console.WriteLine("Yes");

            //Даны два трехзначных числа. Получите новое число присоединением второго числа справа к первому
            //без последних цифр у каждого. Например, 123 и 456 Ответ: 1245.
            //
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //int n = str1.Length - 1;
            //string result = (str1.Remove(n, 1)) + (str2.Remove(n, 1));
            //Console.WriteLine(result);

            //Даны числа h и m, где h - количество часов, m - количество минут некоторого момента времени.
            //Найдите угол между часовой и минутной стрелками в этот момент времени.
            //
            //int h = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //if(!(h > 0 && h < 13 && m >= 0 && m <= 60)) {
            //    Console.WriteLine("Bad h or m");
            //    Console.ReadLine();
            //    return;}
            //double rm = 360*m/60;
            //double rh = 360*(h%12)/12;
            //Console.WriteLine(Math.Abs(rm-rh));

            //Выведите на экран n раз фразу "Silence is golden". Число n вводит пользователь.
            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Silence is golden");
            //}

            //Вывести на экран ряд чисел 1001,  1004,  1007,  ... 1025.
            //
            //for (int i = 1001; i < 1026; i = i + 3)
            //{
            //    Console.WriteLine(i);
            //}

            //for (double i = 25; i < 36; i++)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}", i, i + 0.5, i - 0.2);
            //}

            //Пользователь вводит курс доллара в рублях. Показать таблицу цен 1$, 2$, ..., 100$ в рублях,
            //третьим столбцом добавить количество кг конфет, которые можно купить на данные суммы,
            //если цена 1 кг конфет равна 20 руб. Пример: 1$ - 70 р - 3.5 кг и так далее (всего 100 строк).
            //
            //int r = 70;
            //double kg = 3.5;
            //for (int i = 1; i < 101; i++)
            //{
            //    Console.WriteLine("{0}$ - {1}p - {2}кг", i, r, kg);
            //    r += 70;
            //    kg += 3.5;
            //}

            //Для данного n найти сумму 1+2+3+...+n. Например, для n=10 ответ равен 55.
            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <= n; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //Вывести на экран числа от 1000 до 9999 такие, что все цифры различны.
            //Вывести на экран числа от 1000 до 9999 такие, что среди цифр нет цифр 5 и цифры 6.
            //
            //string str;
            //for (int i = 1005; i < 10000; i++)
            //{
            //    str = i.ToString();
            //    //if (str[0] != str[1] && str[0] != str[2] && str[0] != str[3] &&
            //    //    str[1] != str[2] && str[1] != str[3] &&
            //    //    str[2] != str[3])
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == '5' || str[j] == '6')
            //        {
            //            break;
            //        }
            //        if (j == str.Length-1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //Вывести ряд чисел: десять десяток, девять девяток, восемь восьмерок, ... , одну единицу. Найти сумму всех этих чисел.
            //
            //int sum = 0;
            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //        sum += i;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);

            //Выведите на экран строки вида: (всего n строк, звездочек или 7, или 4 по очереди).
            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("*******");
            //    }
            //    else
            //    {
            //        Console.WriteLine("****");
            //    }
            //}

            //Выведите на экран таблицу умножения для чисел от 1 до 10.
            //
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0, 3} | ",i*j);
            //    }
            //    Console.WriteLine();
            //}

            //Пользователь вводит ненулевые числа до тех пор пока не введет ноль.Найдите сумму этих чисел.
            //
            //int i;
            //int sum = 0;
            //while (true)
            //{
            //    i = Convert.ToInt32(Console.ReadLine());
            //    if (i == 0)
            //    {
            //        break;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //Найдите n-ое число Фибоначчи.
            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(fib(n));

            //Найдите n-ое число Фибоначчи.
            //
            //int n = Convert.ToInt32(Console.ReadLine());
            //int f1 = 1;
            //int f2 = 1;
            //int i = 2;
            //int sum = 0;
            //while (i < n)
            //{
            //    sum = f1 + f2;
            //    f1 = f2;
            //    f2 = sum;
            //    i += 1;
            //}
            //Console.WriteLine(sum);

            Console.ReadLine();
        }

        //Найдите n-ое число Фибоначчи.
        //static int fib(int n)
        //{
        //    return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        //}
    }
}
