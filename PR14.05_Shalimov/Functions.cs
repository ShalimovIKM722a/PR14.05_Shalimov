using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14._05_Shalimov
{
    public class Functions
    {
        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static bool Parity(int num) {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int MaxNumber(int[] nums)
        {
            return nums.Max();
        }

        public static double AverageNumber(double[] nums)
        {
            return nums.Average();
        }

        public static bool NumberInList(double[] nums,double numbers)
        {
            bool result = false;

            foreach(double number in nums)
            {
                if (number == numbers)
                {
                    result = true;
                }
            }
            return result;
        }

        public static string SumString (string str1, string str2)
        {
            return str1+str2;
        }

        public static bool Polindrom(int num)
        {
            string str = num.ToString();
            if (str == str.Reverse())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SumNumbersInArray(int[] nums)
        {
            return nums.Sum();
        }
     
    }
}
