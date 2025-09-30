using ConsoleApp2;
using System;
using System.Security.Claims;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            //Console.WriteLine("1.1");
            //Class class11 = new Class();

            //double number = ConsoleValidator.ReadValidatedDouble(
            // "Введите вещественное число: ",
            // double.MinValue, double.MaxValue, false
            //);

            //double result = class11.fraction(number);

            //Console.Write("Дробная часть числа: ");
            //Console.WriteLine(result);

            //1.3
            //Console.WriteLine("1.3");
            //Class class13 = new Class();

            //char digit = ConsoleValidator.ReadValidatedChar(
            //    "Введите цифру: ",
            //    ConsoleValidator.CharValidationOptions.DigitsOnly
            //);

            //double j = class13.charToNum(digit);
            //Console.WriteLine(j);

            //1.5
            //Console.WriteLine("1.5");
            //Class class15 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //bool y = class15.is2Digits(n);
            //Console.WriteLine(y);

            //1.7
            //Console.WriteLine("1.7");
            //Class class17 = new Class();
            //Console.WriteLine("Введите диапазон: ");
            //int a = ConsoleValidator.ReadValidatedInt("Начало диапазона: ", int.MinValue, int.MaxValue);
            //int b = ConsoleValidator.ReadValidatedInt("Конец диапазона: ", int.MinValue, int.MaxValue);
            //int x = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //bool r = class17.isInRange(a, b, x);
            //Console.WriteLine(r);

            ////1.9
            //Console.WriteLine("1.9");
            //Class class19 = new Class();
            //Console.WriteLine("Введите 3 числа: ");
            //int a = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int b = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int x = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //bool r = class19.isEqual(a, b, x);
            //Console.WriteLine(r);

            ////2.1
            //Console.WriteLine("2.1");
            //Class class21 = new Class();
            //int a = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //int r = class21.abs(a);
            //Console.WriteLine(r);

            ////2.3
            //Console.WriteLine("2.3");
            //Class class23 = new Class();
            //int a = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //bool r = class23.is35(a);
            //Console.WriteLine(r);

            ////2.5
            //Console.WriteLine("2.5");
            //Class class25 = new Class();
            //Console.WriteLine("Введите 3 числа: ");
            //int a = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int b = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int c = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int r = class25.max3(a, b, c);
            //Console.WriteLine(r);

            ////2.7
            //Console.WriteLine("2.7");
            //Class class27 = new Class();
            //Console.WriteLine("Введите 2 числа: ");
            //int a = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int b = ConsoleValidator.ReadValidatedInt("", int.MinValue, int.MaxValue);
            //int r = class27.sum2(a, b);
            //Console.WriteLine(r);

            ////2.9
            //Console.WriteLine("2.9");
            //Class class29 = new Class();
            //int a = ConsoleValidator.ReadValidatedInt("Введите день недели (1-7): ", 1, 7);
            //string r = class29.day(a);
            //Console.WriteLine(r);

            ////3.1
            //Console.WriteLine("3.1");
            //Class class31 = new Class();
            //int x = ConsoleValidator.ReadValidatedInt("Введите число: ", 0, int.MaxValue);
            //string r = class31.listNums(x);
            //Console.WriteLine(r);

            ////3.3
            //Console.WriteLine("3.3");
            //Class class33 = new Class();
            //int x = ConsoleValidator.ReadValidatedInt("Введите число: ", 0, int.MaxValue);
            //string r = class33.chet(x);
            //Console.WriteLine(r);

            ////3.5
            //Console.WriteLine("3.5");
            //Class class35 = new Class();
            //long a = ConsoleValidator.ReadValidatedNumber<long>("Введите число: ", long.MinValue, long.MaxValue);
            //int r = class35.numLen(a);
            //Console.WriteLine(r);

            ////3.7
            //Console.WriteLine("3.7");
            //Class class37 = new Class();
            //int a = ConsoleValidator.ReadValidatedInt("Введите число: ", 1, int.MaxValue);
            //class37.square(a);

            ////3.9
            //Console.WriteLine("3.9");
            //Class class39 = new Class();
            //int a = ConsoleValidator.ReadValidatedInt("Введите число: ", 1, int.MaxValue);
            //class39.rightTriangle(a);

            ////4.1
            //Console.WriteLine("4.1");
            //Class class41 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива: ", 1, int.MaxValue);
            //int[] arr = class41.GenerateRandomArray(n);
            //class41.PrintArray(arr);
            //int x = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //int result = class41.findFirst(arr, x);
            //Console.WriteLine($"{result}");

            ////4.3
            //Console.WriteLine("4.3");
            //Class class43 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива: ", 1, int.MaxValue);
            //int[] arr = class43.GenerateRandomArray(n);
            //class43.PrintArray(arr);
            //int result = class43.maxAbs(arr);
            //Console.WriteLine($"{result}");

            ////4.5
            //Console.WriteLine("4.5");
            //Class class45 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива arr: ", 0, int.MaxValue);
            //int[] arr = class45.GenerateRandomArray(n);
            //class45.PrintArray(arr);
            //int n2 = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива ins: ", 0, int.MaxValue);
            //int[] ins = class45.GenerateRandomArray(n2);
            //class45.PrintArray(ins);
            //int x = ConsoleValidator.ReadValidatedInt("Введите позицию: ", 0, n);
            //int[] result = class45.add(arr, ins, x);
            //class45.PrintArray(result);

            ////4.7
            //Console.WriteLine("4.7");
            //Class class47 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива: ", 1, int.MaxValue);
            //int[] arr = class47.GenerateRandomArray(n);
            //class47.PrintArray(arr);
            //int[] result = class47.reverseBack(arr);
            //class47.PrintArray(result);

            ////4.9
            //Console.WriteLine("4.9");
            //Class class49 = new Class();
            //int n = ConsoleValidator.ReadValidatedInt("Введите количество элементов массива: ", 1, int.MaxValue);
            //int[] arr = class49.GenerateRandomArray(n);
            //class49.PrintArray(arr);
            //int x = ConsoleValidator.ReadValidatedInt("Введите число: ", int.MinValue, int.MaxValue);
            //int[] result = class49.findAll(arr, x);
            //class49.PrintArray(result);
        }
    }
}
