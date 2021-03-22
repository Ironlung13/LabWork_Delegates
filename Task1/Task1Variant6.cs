using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Delegates
{
    public class Task1Variant6
    {
        private static readonly int info1 = 0;
        private static readonly int info2 = 42069;
        private static readonly int info3 = -39923;
        public static string Method1(Action<int> deleg, bool condition, char symbol)
        {
            deleg(info1);
            if (condition)
            {
                return new string(symbol, 10);
            }
            else
            {
                return new string(symbol, 15);
            }
        }

        public static string Method2(Action<int> deleg, bool condition, char symbol)
        {
            deleg(info2);
            if (condition)
            {
                return new string(symbol, 100);
            }
            else
            {
                return new string(symbol, 1);
            }
        }

        public static string Method3(Action<int> deleg, bool condition, char symbol)
        {
            deleg(info3);
            if (condition)
            {
                return new string(symbol, 39);
            }
            else
            {
                return new string(symbol, 3);
            }
        }
        public static void ActionMethod1(int number)
        {
            Console.WriteLine($"Method 1: number is {number}");
        }

        public static void ActionMethod2(int number)
        {
            Console.WriteLine("THIS IS METHOD 2!!!");
            Console.WriteLine($"Changed number to {number - 10}");
        }
    }
}
