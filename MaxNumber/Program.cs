using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max Number Application");
            Console.WriteLine("Enter the numbers to compare");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            Compare comp = new Compare();
            int maxNumber = comp.compareIntegers(number1, number2, number3);
            Console.WriteLine("The max number is " + maxNumber);

            Console.WriteLine("Enter the double numbers to compare");
            double double1 = Convert.ToDouble(Console.ReadLine());
            double double2 = Convert.ToDouble(Console.ReadLine());
            double double3 = Convert.ToDouble(Console.ReadLine());
            double maxDouble = comp.compareDoubles(double1, double2, double3);
            Console.WriteLine("The max double is " + maxDouble);
        }
    }
}
