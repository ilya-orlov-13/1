using System;
using ConsoleApp2;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            //проверка на целое число
            //Console.WriteLine("1.1");
            //Class class11 = new Class();
            //Console.Write("Введите вещественное число: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double r = class11.fraction(x);
            //Console.Write("Дробная часть числа: ");
            //Console.WriteLine(r);

            //1.3
            //диапазон
            //Console.WriteLine("1.3");
            //Class class13 = new Class();
            //Console.Write("Введите цифру: ");
            //char c = Convert.ToChar(Console.ReadLine());
            //double j = class13.charToNum(c);
            //Console.WriteLine(j);

            //1.5
            //проверка на дробное число
            //Console.WriteLine("1.5");
            //Class class15 = new Class();
            //Console.Write("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //bool y = class15.is2Digits(n);
            //Console.WriteLine(y);

            //1.7
            //проверка на целое число
            //Console.WriteLine("1.7");
            //Class class17 = new Class();
            //Console.WriteLine("Введите диапазон: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //bool r = class17.isInRange(a,b,x);
            //Console.WriteLine(r);

            //1.9
            Console.WriteLine("1.9");
            Class class19 = new Class();
            Console.WriteLine("Введите 3 числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            bool r = class19.isEqual(a, b, x);
            Console.WriteLine(r);
        }
    }
}
