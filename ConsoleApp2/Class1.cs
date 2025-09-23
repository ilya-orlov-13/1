using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class
    {
        public double fraction(double x)
        {
            int a = (int)x;
            double b = x - a;
            return b;
        }

        public int charToNum(char x)
        {
            int c = x - '0';
            return c;
        }

        public bool is2Digits(int x)
        {
            int c = 0;
            while (x != 0)
            {
                x /= 10;
                c++;
            }
            if (c == 2) return true;
            else return false;
        }

        public bool isInRange(int a, int b, int num)
        {
            if (a < b)
            {
                if (a <= num && num <= b) return true;
                else return false;
            }
            else
            {
                if (b <= num && num <= a) return true;
                else return false;
            }
        }

        public bool isEqual(int a, int b, int c)
        {
            if (a == b && a == c) return true;
            else return false;
        }

        public int abs(int x)
        {
            if (x > 0) return x;
            else return x * -1;
        }

        public bool is35(int x)
        { 
            if (x % 3 == 0 && x % 5 == 0) return false;
            if (x% 3 == 0 || x % 5 == 0) return true;
            else return false;
        }

        public int max3(int x, int y, int z)
        {
            if (x >= y && x >= z) return x;
            if (y >= x && y >= z) return y;
            else return z;
        }

        public int sum2(int x, int y)
        {
            if (x + y < 10 || x + y > 19) return x + y;
            else return 20;
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "это не день недели";
            }
        }

        public String listNums(int x)
        {
            string s= "";
            for (int i = 0; i <= x; i++)
            {
                s += i + " ";
            }
            return s;
        }

        public String chet(int x)
        {
            string s = "";
            for (int i = 0; i <= x; i+=2)
            {
                s += i + " ";
            }
            return s;
        }

        public int numLen(long x)
        {
            int c = 0;
            while (x != 0)
            {
                x /= 10;
                c++;
            }
            return c;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int[] GenerateRandomArray(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Количество элементов должно быть положительным числом");
            }

            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-51, 51);
            }

            return arr;
        }

        public void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        public int maxAbs(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Массив пустой");
            }

            int maxAbsValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxAbsValue))
                {
                    maxAbsValue = arr[i];
                }
            }

            return maxAbsValue;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            if (pos < 0 || pos > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Позиция должна быть в диапазоне от 0 до " + arr.Length);
            }

            int[] result = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                result[ins.Length + i] = arr[i];
            }

            return result;
        }

        public int[] reverseBack(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Массив пустой");
            }

            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        public int[] findAll(int[] arr, int x)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Массив пустой");
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            int[] result = new int[count];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }
    }
}
