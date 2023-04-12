using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("----------------------Task 1----------------------");
            Action<decimal> dollar= Bank;
            dollar(12123m);
            Console.WriteLine(new string('-', 50));

            //2
            Console.WriteLine("----------------------Task 2----------------------");
            Func<double,double> digit = Square;
            Console.WriteLine(digit(5.342));
            Console.WriteLine(new string('-', 50));

            //3
            Console.WriteLine("----------------------Task 3----------------------");
            Predicate<int> math = IsEven;
            List<int> numbers = new List<int>() {23,43,76,87,157,54 };
            EvenDigit(numbers, math);
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            //4
            Console.WriteLine("----------------------Task 4----------------------");
            Action<int> maths = AddNumber;
            List<int> numbers1 = new List<int> { 23, 43, 76, 87, 157, 54 };
            Filter(numbers1, maths);
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            //5
            Console.WriteLine("----------------------Task 5----------------------");
            Action<int> input = NumberOfAvarage;
            Action<int> input2 = NumberOfSum;
            List<Action<int>> actions = new List<Action<int>>() { input, input2 };
            Console.Write("NumberOfAvarage:");
            NumberOfAvarage(3);
            Console.WriteLine();
            Console.Write("NumberOfSum:");
            NumberOfSum(2);
            Console.WriteLine();

            //6
            Console.WriteLine("----------------------Task 6----------------------");
            Predicate<string> name = NameLength;
            List<string> names = new List<string> { "Tamerlan","Tural", "Turan", "Benovse","Jale" };
            FilterNames(names, name);
        }

        static void Bank(decimal money)
        {
            Console.WriteLine(money);
        }


        public static double Square(double digit)
        {
            return digit * digit;
        }


        public static void EvenDigit(List<int> numbers, Predicate<int> math)
        {
            foreach (var item in numbers)
            {
                if (math(item))
                {
                    Console.Write($"{item},");
                }
            }
        }
        public static bool IsEven(int item)
        {
            if(item % 2 == 0)
            {
                return true;
            }
            return false;
        }
        
        
        public static void Filter(List<int> numbers1, Action<int> maths)
        {
            foreach (var item in numbers1)
            {
                maths(item);
            }
        }
        public static void AddNumber(int item)
        {
            Console.Write($"{item + 1},");
            
        }

        public static void NumberOfAvarage(int digit2)
        {
            Console.Write((digit2+digit2)/2);
        }
        public static void NumberOfSum(int digit1)
        {
            Console.Write(digit1+digit1);
        }


        public static void FilterNames(List<string> names, Predicate<string> name)
        {
            foreach (var i in names)
            {
                if (NameLength(i))
                {
                    Console.Write(i+",");
                }
            }
        }
        public static bool NameLength(string i)
        {
            if (i.Length >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
