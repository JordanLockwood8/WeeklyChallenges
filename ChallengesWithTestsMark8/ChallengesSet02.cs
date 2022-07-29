using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
            //string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQWRSTUVWXYZ";
            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    if (alphabet[i] == c)
            //    {
            //        return true;
            //    }                
            //        return false;                
            //}
        }


        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
            //if (vals.Length % 2 == 0)
            //{
            //    return true;
            //}
            //return false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
            //if (number % 2 ==0)
            //
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {  //Null or empty check
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            var min = numbers.Min();
            var max = numbers.Max();            
            var sum = min + max;            
            return sum;

            //return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
            //return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {

            if(numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
            //return numbers!= null && numbers.Count() % 2 != 0 && numbers.Sum() % 2 ==0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            return number / 2;
            //return number <=0 ? 0 : number / 2;
        }
    }
}
