using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            if (vals == null)
            {
                return false;
            }
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //int sum = 0;
            //foreach (var item in numbers)
            //{
            //    if (item % 2 != 0)
            //    {
            //        sum += item;
            //    }
            //}
            //return sum % 2 != 0; 

            //if (numbers == null)
            //{
            //    return false;
            //}
            //int sum = numbers.Where(x => x % 2 != 0).Sum();
            //if (sum % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}           
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
            //var isUpper = password.Any(char.IsUpper);
            //var isLower = password.Any(char.IsLower);
            //var isNum = password.Any(char.IsNumber);
            //if (isUpper && isLower && isNum)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First(x => x == x);
            
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last(x => x == x);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else if (dividend == 0)
            {
                return 0;
            }
            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Last();
            var first = nums.First();
            return last - first;
        }

        public int[] GetOddsBelow100()
        {

            return Enumerable.Range(1, 100).Where(i => i % 2 != 0).ToArray();

            //var odds = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 !=0)
            //    {
            //        odds.Add(i);
            //    }                
            //}
            //return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (var item in words)
            {
                item.ToUpper();
            }
        }
    }
}
