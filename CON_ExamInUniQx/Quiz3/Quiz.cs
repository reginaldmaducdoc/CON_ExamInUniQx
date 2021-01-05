using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_ExamInUniQx.Quiz3
{
    public class Quiz
    {
        const int MAX_SIZE = 15000;
        public static void Start()
        {
            int[] arrResult;
            Console.Write("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = GetPrimeFactors(n, out arrResult);
            int rev = count -1;
            for (int i = 0; i < count; i++)
            {
                Console.Write(arrResult[rev - i]);
                if (i != count - 1)
                    Console.Write(" X ");
            }
            Console.ReadLine();
        }
        static bool IsPrimeNumber(int num)
        {
            bool bPrime = true;
            int factor = num / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((num % i) == 0)
                    bPrime = false;
            }
            return bPrime;
        }
        static public int GetPrimeFactors(int num, out int[] arrResult)
        {
            int count = 0;
            int[] arr = new int[MAX_SIZE];
            arrResult = new int[MAX_SIZE];
            int i = 0;
            int idx = 0;
            for (i = 2; i <= num; i++)
            {
                if (IsPrimeNumber(i) == true)
                    arr[count++] = i;
            }
            while (true)
            {
                if (IsPrimeNumber(num) == true)
                {
                    arrResult[idx++] = num;
                    break;
                }
                for (i = count - 1; i >= 0; i--)
                {
                    if ((num % arr[i]) == 0)
                    {
                        arrResult[idx++] = arr[i];
                        num = num / arr[i];
                        break;
                    }
                }
            }
            return idx;
        }
    }
}
