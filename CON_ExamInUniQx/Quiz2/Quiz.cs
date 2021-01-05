using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_ExamInUniQx.Quiz2
{
    public class Quiz
    {
        public static void Start()
        {
            int dec, i;
            int[] a = new int[10];
            Console.Write("Enter first number: ");
            dec = int.Parse(Console.ReadLine());

            for (i = 0; dec > 0; i++)
            {
                a[i] = dec % 2;
                dec = dec / 2;
            }

            Console.Write("OUTPUT: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadLine();
        }
    }
}
