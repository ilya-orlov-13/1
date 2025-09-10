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
            int c=0;
            while (x != 0)
            {
                x /= 10;
                c++;
            }
            if (c == 2) return true;
            else return false;
        }

        public bool isInRange(int a,int b,int num)
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

        public bool isEqual(int a,int b,int c)
        {
            if (a == b && a == c) return true;
            else return false;
        }

        public int abs(int x)
        {
            if(x>0)
        }
    }
}
