using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try {
                var input = Int32.Parse(Console.ReadLine());
                if (IsLeapYear(input)){
                    Console.WriteLine("yay");
                } else {
                    Console.WriteLine("nay");
                }
            } catch (FormatException) {
                Console.WriteLine("Exception! Please write a number...");
            }
        }

        public static bool IsLeapYear(int year) 
        {
            if (year <= 1581) {
                throw new InvalidInputException("The year " + year + " is too soon!");
            } else {
                if (year % 4 == 0) {
                    if (year % 100 != 0 || year % 400 == 0) {
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    return false;
                }
            }
        }
    }
}
