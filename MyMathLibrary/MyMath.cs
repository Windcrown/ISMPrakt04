using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLibrary
{
    public class MyMath
    {
        public static int for1(int x, int y)
        {
            int d = 1;
            for (int i = x; i <= y; i++)
            {
                d *= i;
            }
            return d;
        }

        public static double for2(int x)
        {
            double s = 1;
            for (int i = 2; i <= x; i++)
            {
                s += 1.0 / i;
            }
            return s;
        }

        public static double for3(double x, int y)
        {
            double res = 1;
            for (int i = 1; i <= y; i++)
            {
                res *= x;
            }
            return res;
        }

        public static int for5(int x)
        {
            int res = 1;
            for (int i = 1; i <= x; i++)
            {
                res *= i;

            }

            return res;
        }


        public static int for4(int x, int y)
        {
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public static double while1(int x)
        {
            double s = 0; int temp = x;
            for (int i = 1; i <= x; i++)
            {
                s += Math.Pow(i, temp--);
            }
            return s;
        }

        public static int while2(int x)
        {
            int min = 0;
            for (int i = 1; i <= x; i++)
            {
                if (Math.Pow(3, i) > x)
                {
                    min = i;
                    break;
                }
            }
            return min;
        }

        public static double while3(double percent)
        {
            double s = 10;
            percent /= 100;
            percent += 1;
            double speed = s;
            double res = 0;
            int days = 0;
            for (int i = 2; ; i++)
            {
                speed *= percent;
                res += speed;
                if (res > 200)
                {
                    days = i;
                    break;
                }
            }

            return days;

        }
    }
}
