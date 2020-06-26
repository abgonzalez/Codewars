using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public static class Kata
    {
        /// <summary>
        /// Algorithm to convert Decimal to Binary number
        /// Divide the input decimal number by 2 and store the remainder.
        /// Store the quotient back to the input number variable.
        /// Repeat this process till quotient becomes zero.
        ///  Equivalent binary number will be the remainders in above process in reverse order.
        public static int CountBits(int n)
        {
            ArrayList binary = new ArrayList();
            int quotient = (int)(n / 2);
            int numberBits = 0;
            while (quotient > 0)
            {
                quotient = (int)(n / 2);
                if ((n % 2) == 1)
                    ++numberBits;
                n = quotient;
            }

            return numberBits;
        }
        public static int CountBitsClever(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
        public static int DescendingOrder(int num)
        {
            char[] arrayNum = num.ToString().ToCharArray();
            char[] sortedNum = (from number in arrayNum orderby number descending select number).ToArray();
            string stringNumber = new string(sortedNum);
            if (Int64.TryParse(stringNumber, out long result))
                return (int)result;
            return 0;
        }
        public static int DescendingOrderClever(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
        ///The goal of this exercise is to convert a string to a new string 
        /// where each character in the new string is "(" 
        ///  if that character appears only once in the original string, 
        ///  or ")"  if that character appears more than once in the original string. 
        ///  Ignore capitalization when determining if a character is a duplicate.
        ///
        public static string DuplicateEncode(string words)
        {
            char[] arrayWord = words.ToCharArray();
            var duplicates = from word in arrayWord
                             group word.ToString().ToLower() by word.ToString().ToLower() into wordRecord
                             where wordRecord.Count() > 1
                             select new
                             {
                                 word = wordRecord.Key.ToString(),
                                 num = wordRecord.Count()
                             };
            char[] result = new char[words.Length];
            for (int i = 0; i < words.Length; ++i)
            {
                if (duplicates.Where(c => c.word == words[i].ToString().ToLower()).Count() != 0)
                {
                    result[i] = ')';
                }
                else
                {
                    result[i] = '(';
                }
            }
            return new string(result);
        }
        public static string DuplicateEncodeClever(string word)
        {
               return new string (word.ToLower().
                   Select(ch => word.ToLower().
                   Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
        /// <summary>
        /// Write a function that will return the count
        /// of distinct case-insensitive alphabetic characters 
        /// and numeric digits that occur more than once in the input string. 
        /// The input string can be assumed to contain only alphabets
        /// (both uppercase and lowercase) and numeric digits.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int DuplicateCount(string str)
        {
            var duplicates = (from word in str
                             group word.ToString().ToLower()
                             by word.ToString().ToLower() into wordRecord
                             where wordRecord.Count() > 1
                             select (wordRecord)).Count();
            return duplicates;
        }
        public static int DuplicateCountClever(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
        /// <summary>
        /// You are going to be given an array of integers.
        /// Your job is to take that array and find an index N
        /// where the sum of the integers to the left of N is equal 
        /// to the sum of the integers to the right of N. 
        /// If there is no index that would make this happen, return -1.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindEvenIndex(int[] arr)
        {
            int leftSum = 0, rightSum = arr.Sum();

            for (int i = 0; i < arr.Length; ++i)
            {
                rightSum -= arr[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += arr[i];
            }

            return -1;


        }
    }
}
