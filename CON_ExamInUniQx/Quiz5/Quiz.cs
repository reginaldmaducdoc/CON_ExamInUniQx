using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_ExamInUniQx.Quiz5
{
    public class Quiz
    {
        public static void Start()
        {
            int num1, rem1;
            Console.Write("enter any odd number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("Only odd numbers are allowed.");
            }              
            else
            {
                generateSquare(num1);
            }              
            Console.ReadLine();
        }

        static void generateSquare(int n)
        {
            int[,] Square = new int[n, n];
            int i = n / 2;
            int j = n - 1;
            for (int num = 1; num <= n * n;)
            {
                if (i == -1 && j == n) 
                {
                    j = n - 2;
                    i = 0;
                }
                else
                {
                    if (j == n)
                        j = 0;
                    if (i < 0)
                        i = n - 1;
                }
                if (Square[i, j] != 0)
                {
                    j -= 2;
                    i++;
                    continue;
                }
                else
                    Square[i, j] = num++;
                j++;
                i--;
            }
            Console.WriteLine("OUTPUT:");
    
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(Square[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
