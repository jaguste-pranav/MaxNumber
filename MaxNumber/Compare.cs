using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumber
{
    public class Compare
    {
        public int compareIntegers(int number1, int number2, int number3)
        {
            int maxNumber = 0;

            if (number1.CompareTo(number2) > 0 && number1.CompareTo(number3) > 0)
            {
                maxNumber = number1;
            }
            else if (number2.CompareTo(number1) > 0 && number2.CompareTo(number3) > 0)
            {
                maxNumber = number2;
            }
            else if (number3.CompareTo(number2) > 0 && number3.CompareTo(number1) > 0)
            {
                maxNumber = number3;
            }
            else
            {
                throw new Exception("Please enter different Numbers");
            }

            return maxNumber;
        }

        public double compareDoubles(double number1, double number2, double number3)
        {
            double maxDouble = 0;

            if (number1.CompareTo(number2) > 0 && number1.CompareTo(number3) > 0)
            {
                maxDouble = number1;
            }
            else if (number2.CompareTo(number1) > 0 && number2.CompareTo(number3) > 0)
            {
                maxDouble = number2;
            }
            else if (number3.CompareTo(number2) > 0 && number3.CompareTo(number1) > 0)
            {
                maxDouble = number3;
            }
            else
            {
                throw new Exception("Please enter different Numbers");
            }

            return maxDouble;
        }

        public string compareString(string string1, string string2, string string3)
        {
            string maxString = "";
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0)
            {
                maxString = string1;
            }
            else if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
            {
                maxString = string2;
            }
            else if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0)
            {
                maxString = string3;
            }
            else
            {
                throw new Exception("Please enter different strings");
            }

            return maxString;
        }
    }

    public class MaxValue<T> where T : IComparable
    {
        T[] inputArray;
        public MaxValue(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public T getMax()
        {
            Array.Sort(inputArray);
            return inputArray[inputArray.Length - 1];
        }

        public T printMax()
        {
            Console.WriteLine("Max Value: "+getMax());
            return inputArray[inputArray.Length - 1];
        }
    }
}
