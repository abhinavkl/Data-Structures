using DataStructuresPrograms.Code.Basic;
using DataStructuresPrograms.Code.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructuresPrograms.Code.Objects
{
    class StringLengthComparator : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return (a.Length.CompareTo(b.Length));
        }
    }
    class NumberHolder<T>
    {
        public T Positive { get; set; }
        public T Negative { get; set; }
    } 
    internal class BigInteger
    {
        public BigInteger() { }
        public BigInteger(String str) 
        {
            Integer = new int[0];
            Int = str;
        }
        public int[] Integer { get; set; }
        public string Int { get; set; }

        public static BigInteger Add(params BigInteger[] integers)
        {
            int n = 0;
            n = integers.Max(bi => bi.Int.Length);
            int[] digits = new int[integers.Length];
            int i = 0;

            if (n > 0)
            {

                List<int> result = new List<int>();
                /* foreach (BigInteger integer in integers)
                 {
                     digits[i++] = integer.Integer.Length;
                 }

                 i = 0;
                 while (i != n)
                 {
                     int curDigitSum = 0;
                     int j = 0;
                     foreach (BigInteger integer in integers)
                     {
                         if (digits[j] != 0)
                         {
                             bool isNegative=Math.Abs(integer.Integer[0])!=integer.Integer[0];
                             curDigitSum += isNegative? Math.Abs(integer.Integer[--digits[j]])*-1: integer.Integer[--digits[j]];
                         }
                         j++;
                     }
                     if (curDigitSum >= 0)
                     {
                         result.Add((carrier + curDigitSum) % 10);
                         carrier = (carrier + curDigitSum) / 10;
                     }
                     else
                     {
                         result.Add(((carrier + curDigitSum) % 10) + 10);
                         carrier = ((carrier + curDigitSum) / 10) - 1;
                     }
                     i++;
                 }
                 if (carrier != 0) result.Add(carrier);
                 result.Reverse();
                 */
                return new BigInteger() { Integer = result.ToArray() };

            }
            else
            {
                NumberHolder<int> maxDigitCount=new NumberHolder<int>();
                
                foreach (BigInteger integer in integers)
                {
                    int digitCount = 0;
                    bool isPos = !integer.Int.StartsWith("-");
                    if (isPos)
                    {
                        digitCount = integer.Int.Length;
                        maxDigitCount.Positive = Math.Max(maxDigitCount.Positive,digitCount);                        
                    }
                    else
                    {
                        digitCount = integer.Int.Length - 1;
                        maxDigitCount.Negative=Math.Max(maxDigitCount.Negative,digitCount);
                    }
                    digits[i++] = digitCount;
                }

                NumberHolder<StringBuilder> result = new NumberHolder<StringBuilder>() { Positive=new StringBuilder(), Negative=new StringBuilder() };
                NumberHolder<int> sum = new NumberHolder<int>();
                NumberHolder<int> carrier = new NumberHolder<int>();
                i = 0;
                n = Math.Max(maxDigitCount.Positive,maxDigitCount.Negative);
                while (i != n)
                {
                    bool isPos=true;
                    sum = new NumberHolder<int>();
                    int j = 0;
                    foreach (BigInteger integer in integers)
                    {
                        if (digits[j] != 0)
                        {
                            isPos = !integer.Int.StartsWith("-");
                            if (isPos)
                            {
                                sum.Positive += Convert.ToInt32("" + integer.Int[--digits[j]]);
                            }
                            else sum.Negative += Convert.ToInt32("" + integer.Int[digits[j]--]);
                        }
                        j++;
                    }
                    if (sum.Positive != 0 || sum.Negative!=0)
                    {
                        if (sum.Positive!=0)
                        {
                            result.Positive.Insert(0, Convert.ToString((carrier.Positive + sum.Positive) % 10));
                            carrier.Positive = (carrier.Positive + sum.Positive) / 10;
                        }
                        if(sum.Negative!=0)
                        {
                            result.Negative.Insert(0, Convert.ToString((carrier.Negative + sum.Negative) % 10));
                            carrier.Negative = (carrier.Negative + sum.Negative) / 10;
                        }
                    }
                    i++;
                }

                if (carrier.Positive != 0) result.Positive.Insert(0, Convert.ToString((carrier.Positive)));
                if (carrier.Negative != 0) result.Negative.Insert(0, Convert.ToString((carrier.Negative)));

                if (result.Positive.Length == result.Negative.Length)
                {
                    if (Convert.ToInt32("" + result.Positive[0]) > Convert.ToInt32("" + result.Negative[0]))
                        return Substract(new BigInteger(result.Positive.ToString()), new BigInteger(result.Negative.ToString()));
                    else return new BigInteger(Substract(new BigInteger(result.Negative.ToString()), new BigInteger(result.Positive.ToString())).Int.Insert(0,"-"));
                }
                else
                {
                    if (result.Positive.Length > result.Negative.Length)
                        return Substract(new BigInteger(result.Positive.ToString()), new BigInteger(result.Negative.ToString()));
                    else return new BigInteger(Substract(new BigInteger(result.Negative.ToString()), new BigInteger(result.Positive.ToString())).Int.Insert(0, "-"));
                }
            }
        }
        public static BigInteger Substract(BigInteger positive,BigInteger negative)
        {
            int positiveLength=positive.Int.Length;
            int negativeLength=negative.Int.Length;
            int subtractor = 0;
            StringBuilder result = new StringBuilder();
            int i = 0;
            while(i++!= negative.Int.Length)
            {
                int posValue = Convert.ToInt32(""+ positive.Int[--positiveLength]);
                int negValue = Convert.ToInt32(""+ negative.Int[--negativeLength]);
                if (posValue + subtractor >= negValue)
                {
                    subtractor = 0;
                    result.Insert(0, posValue - negValue);
                }
                else
                {
                    if (subtractor == 0)
                    {
                        result.Insert(0,posValue - negValue + 10);
                    }
                    else
                    {
                        result.Insert(0,posValue-negValue+9);
                    }
                    subtractor = -1;
                }
            }
            if(positiveLength!=0)
                result.Insert(0, Convert.ToInt32("" + positive.Int.Substring(0,positiveLength)) + subtractor);
    
            return new BigInteger(result.ToString());
        }

        static string Multiply(string first, string second)
        {
            if ("1".Equals(first)) return second;
            else if ("1".Equals(second)) return first;
            else
            {
                int firstDigitCount = first.Length;
                int secondDigitCount = second.Length;

                if (firstDigitCount > secondDigitCount) return Multiply(second, first);

                StringBuilder result = new StringBuilder();
                int carrier = 0;
                for (int i = 0; i < firstDigitCount + secondDigitCount - 1; i++)
                {
                    int prod = 0;
                    for (int j = 0; j <= i && j < firstDigitCount; j++)
                    {
                        if (i - j < secondDigitCount)
                        {
                            prod += Convert.ToInt32("" + first[firstDigitCount - j - 1]) * Convert.ToInt32("" + second[secondDigitCount - i + j - 1]);
                        }
                    }
                    result.Insert(0, Convert.ToString((carrier + prod) % 10));
                    carrier = (prod + carrier) / 10;
                }
                if (carrier != 0) result.Insert(0, carrier);
                return result.ToString();
            }
        }
        public static BigInteger Multiply(params BigInteger[] integers)
        {
            string result = "1";
            int sign = 1;
            List<string> ints = new List<string>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i].Int.StartsWith("-"))
                {
                    sign *= -1;
                    ints.Add(integers[i].Int.Substring(1));
                }
                else
                {
                    ints.Add(integers[i].Int);
                }
            }

            ints.Sort(new StringLengthComparator());

            foreach (string str in ints)
            {
                result = Multiply(result, str);
            }
            if (sign == -1) result="-"+result;
            return new BigInteger(result);
        } 

        public static BigInteger Factorial(BigInteger integer)
        {
            if(Regex.Match(integer.Int, @"^0{1,}$").Success || Regex.Match(integer.Int, @"^0{0,}1$").Success)
            {
                return new BigInteger("1");
            }

            if(Regex.Match(integer.Int, @"^[0-9]{1,}$").Success)
            {
                var removeStartingZeros = Regex.Replace(integer.Int, @"^(0{0,})([0-9]{0,})$", m => {
                    if(m.Groups[1].Value.Length!=0)
                        return m.Value.Replace(m.Groups[1].Value, "");
                    return m.Value;
                });
                var afterRemovingFirstZeros = new BigInteger(removeStartingZeros);
                return Multiply(afterRemovingFirstZeros, Factorial(Substract(afterRemovingFirstZeros, new BigInteger("1"))));
            }
            else return new BigInteger("-1");
            
        }

    }
}
