using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpSwatches
{
    internal static class CodeWarsKata
    {
        internal static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];

            if (n > 0)
            {
                int index = n < 3 ? n : 3;          //kata doesn't recognize math.min?
                for (int i = 0; i < index; i++)
                    result[i] = signature[i];

                for (int i = 2; i < n - 1; i++)
                    result[i + 1] = result[i] + result[i - 1] + result[i - 2];
            }

            return result;
        }

        internal static string PrinterError(string controlString)
        {
            const int letterA = 'a';
            const int letterM = 'm';

            int errorCount = 0;
            controlString.ToList().ForEach(x => { if (x < letterA || x > letterM) errorCount++; });

            return string.Format($"{errorCount}/{controlString.Length}");
        }

        internal static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        internal static string Disemvowel(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            IEnumerable<char> result = s.Where(x => !vowels.Any(y => y == x));

            return new string(result.ToArray());
        }

        /// <summary>
        /// Returns the single integer that is even in a list of odd numbers or vice versa
        /// This version O(log n)
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        internal static int ParityOutlier_v1(int[] ints)
        {
            int oddCount, evenCount, result, oddIndex, evenIndex;
            oddCount = evenCount = result = oddIndex = evenIndex = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    evenCount++;
                    if (evenCount == 1) evenIndex = i;
                }
                else
                {
                    oddCount++;
                    if (oddCount == 1) oddIndex = i;
                }

                if (oddCount == 1 && evenCount > 1)
                {
                    result = ints[oddIndex];
                    break;
                }
                else if (oddCount > 1 && evenCount == 1)
                {
                    result = ints[evenIndex];
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the single integer that is even in a list of odd numbers or vice versa
        /// This version O(2n)
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        internal static int ParityOutlier_v2(int[] ints)
        {
            IEnumerable<int> evens = ints.ToList().Where(x => x % 2 == 0);
            IEnumerable<int> odds = ints.ToList().Where(x => x % 2 != 0);

            return evens.Count() == 1 ? evens.First() : odds.First();
        }

        /// <summary>
        /// Returns the single integer that is even in a list of odd numbers or vice versa
        /// This version O(n)
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        internal static int ParityOutlier(int[] ints)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            ints.ToList().ForEach(x => { if (x % 2 == 0) evens.Add(x); else odds.Add(x); });

            return evens.Count == 1 ? evens[0] : odds[0];
        }

        internal static int GetSum_v1(int a, int b)
        {
            if (a == b)
                return a;

            int lowerBound = (a < b) ? a : b;
            int upperBound = (a == lowerBound) ? b : a;

            int sum = 0;
            do
            {
                sum += lowerBound++;
            } while (lowerBound <= upperBound);

            return sum;
        }

        internal static int GetSum(int a, int b)
        {
            if (a == b)
                return a;

            int lowerBound = Math.Min(a, b);
            int upperBound = Math.Max(a, b);

            return Enumerable.Range(lowerBound, upperBound - lowerBound + 1).Sum();
        }

        internal static string DuplicateEncoder_v1(string word)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            List<char> chars = word.ToLower().ToList();
            chars.ForEach(c => { if (map.ContainsKey(c)) map[c] = ')'; else map.Add(c, '('); });

            var sb = new StringBuilder();
            chars.ForEach(c => sb.Append(map[c]));

            return sb.ToString();
        }

        internal static string DuplicateEncoder(string word)
        {
            var sb = new StringBuilder();
            List<char> chars = word.ToLower().ToList();

            foreach(char c in chars)
                sb.Append(chars.Count(x => x == c) == 1 ? '(' : ')');

            return sb.ToString();
        }

        internal static string YourOrderPlease_v1(string words)
        {
            if (string.IsNullOrEmpty(words))
                return string.Empty;

            string result = string.Empty;
            string[] sorted = new string[10];

            List<string> wordList = words.Split(new char[] { ' ' }).ToList();
            foreach (string word in wordList)
            {
                char c = word.FirstOrDefault(x => char.IsDigit(x));
                string s = c.ToString();
                int index = int.Parse(s);
                if (index > 0)
                    sorted[index - 1] = word;
            }

            StringBuilder sb = new StringBuilder();
            sorted.ToList().ForEach(x => { if (x != null) sb.Append(x + " ");  } );
            result = sb.ToString().TrimEnd();

            return result;
        }

        internal static string YourOrderPlease_v2(string words)
        {
            if (string.IsNullOrEmpty(words))
                return string.Empty;

            var wordList = words.Split(null);
            string[] sorted = new string[wordList.Length];

            foreach (string word in wordList)
            {
                int index = int.Parse(word.FirstOrDefault(x => char.IsDigit(x)).ToString()) -1;
                sorted[index] = word;
            }

            return string.Join(" ", sorted);
        }

        internal static string YourOrderPlease(string words)
        {
            if (string.IsNullOrEmpty(words))
                return words;

            string[] sorted = words.Split(null).OrderBy(x => x.ToList().Find(c => char.IsDigit(c))).ToArray();
            return string.Join(" ", sorted);
        }
    }
}
