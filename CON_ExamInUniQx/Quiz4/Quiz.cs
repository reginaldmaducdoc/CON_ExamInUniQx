using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_ExamInUniQx.Quiz4
{
    public class Quiz
    {
        public static void Start()
        {
            Console.Write("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            findSqrt(n);
            Console.ReadLine();
        }

        static double Square(double n, double i, double j)
        {
            double mid = (i + j) / 2;
            double mul = mid * mid;
            if ((mul == n) ||
                (Math.Abs(mul - n) < 0.00001))
                return mid;
            else if (mul < n)
                return Square(n, mid, j);
            else
                return Square(n, i, mid);
        }
        static void findSqrt(double n)
        {
            double i = 1;
            Boolean found = false;
            while (!found)
            {
                if (i * i == n)
                {
                    Console.WriteLine(i);
                    found = true;
                }

                else if (i * i > n)
                {
                    double res = Square(n, i - 1, i);
                    Console.Write("{0:F11}", res);
                    found = true;
                }
                i++;
            }
        }
    }
}
