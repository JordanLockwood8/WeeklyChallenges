using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    num -= numbers[i];
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arr = new string[] { str1, str2, str3, str4 };
            return arr.Min(x => x.Length);
            //if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            //{
            //    return str1.Length;
            //}
            //else if(str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            //{
            //    return str2.Length;
            //}
            //else if (str3.Length <=str1.Length && str3.Length <= str2.Length && str1.Length <= str4.Length)
            //{
            //    return str3.Length;
            //}
            //else
            //{
            //    return str4.Length;
            //}
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arr = new int[] { number1, number2, number3, number4 };
            return arr.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                   );
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number); //number is unused for the challenge. We only want to return the bool
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {//if the objects null are > objects that are not return true

            int isNull = 0;
            int isNotNull = 0;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    isNull += 1;
                }
                else
                {
                    isNotNull += 1;
                }

            }
            return isNull > isNotNull;

        }

        public double AverageEvens(int[] numbers)
        {
            //return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0)
            //                  .Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0)
            //                  .Average();
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else if (numbers.Where(x => x % 2 ==0).Count() == 0)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
               throw new ArgumentOutOfRangeException();
            }
            int fact = 1;
            for (int x = 1; x <= number; x++)
            {
                fact *= x;
            }
            return fact;
        }
    }
}
