using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Delegates
{
    public static class Task1
    {
        private static string info1 = "YEEEEEEEEEEEES";
        private static int info2 = 42069;
        private static List<int> info3 = new List<int>();
        public static float Method1(Action<object> print, float numb)
        {
            print.Invoke(info1);
            Console.WriteLine($"number is currently: {numb}");
            return numb * 10f;
        }

        public static float Method2(Action<object> print, float numb)
        {
            print.Invoke(info2);
            Console.WriteLine($"number is currently: {numb}");
            return numb + 1f;
        }

        public static float Method3(Action<object> print, float numb)
        {
            print.Invoke(info3);
            Console.WriteLine($"number is currently: {numb}");
            return numb + 1000f;
        }

        public static void PrintInfo1(object obj)
        {
            Console.WriteLine("Method 1:");
            Console.WriteLine(obj);
        }

        public static void PrintInfo2(object obj)
        {
            Console.WriteLine("Method 2:");
            Console.WriteLine($"Object ToString: {obj}");
        }
    }
}
