using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_ExamInUniQx.Quiz1
{
    public class Quiz
    {
        public static void Start()
        {
            int sec1, sec2 , sec3, i, n =10;
            Console.Write("Enter first number:");
            sec1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            sec2 = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("OUTPUT:");
            Console.Write(sec1 + " " + sec2 + " ");
            for (i = 2; i < n; ++i)
            {
                sec3 = sec1 + sec2;
                Console.Write(sec3 + " ");
                sec1 = sec2;
                sec2 = sec3;
            }
            Console.ReadLine();
        }
    }
}
