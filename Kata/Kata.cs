using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    public static class Kata
    {
        public static string ReverseWordsLinq(string str)
        {
            return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
        }
        public static string ReverseWords(string str)
        {
            var i = 0;
            string result = "", word = "";

            while (i < str.Length)
            {
                if (str[i] == ' ')
                {
                    result += word + str[i];
                    word = "";
                }
                else word = str[i] + word;

                i++;
            }
            return result += word;
        }
        public static string FindNeedle(object[] haystack)
        {
            return haystack.ToList().IndexOf("needle").ToString("found the needle at position 0");
        }
        public static long[] Digitize(long n)
        {
            long[] arr = new long[n.ToString().Length];
            var i = 0;
            while (n > 0)
            {
                arr[i] = n % 10;
                n = (n - arr[i++]) / 10;
            }

            return arr;
        }
        public static string SumOfTheFirstNthTermOfSeries(int number)
        {
            float sum = 0;
            float del = 1;

            for (int i = 0; i < number; i++)
            {
                sum += 1 / del;
                del += 3;
            }

            return sum.ToString("0.00");
        }
        public static int MakeNegative(int number)
        {
            return number < 0 ? number : -number;
        }
        public static long SumTwoSmallestNumbers(long[] numbers)
        {
            var list = new List<long>(numbers);
            list.Sort();
            return list[0] + list[1];
        }
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int i = 0;

            while (p > p0)
            {
                p0 += Convert.ToInt32(p0 * (percent / 100) + aug);
                i++;
            }
            return i;
        }
    }
}
