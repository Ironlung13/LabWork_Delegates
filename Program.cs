using System;

namespace LabWork_Delegates
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose task:");
            Console.WriteLine("1: Func<Action<int>, bool, char, string>");
            Console.WriteLine("2: Ping-Pong");
        Choice:
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    TaskNumber1();
                    break;
                case "2":
                    Console.Clear();
                    PlayGame();
                    break;
                default:
                    goto Choice;
            }

            Console.WriteLine();
            Console.WriteLine("To quit, enter \"q\"");
            Console.WriteLine("To restart program, enter anything else.");
            switch (Console.ReadLine())
            {
                case "q":
                case "Q":
                    return;
                default:
                    Console.Clear();
                    Main();
                    return;
            }
        }
        public static void TaskNumber1()
        {
            Func<Action<int>, bool, char, string> func = Task1Variant6.Method1;
            func += Task1Variant6.Method2;
            func += Task1Variant6.Method3;

            Console.WriteLine("Using ActionMethod1 method:");
            Console.WriteLine(func(Task1Variant6.ActionMethod1, true, 'Y'));
            Console.WriteLine();

            Console.WriteLine("Using ActionMethod2 method:");
            Console.WriteLine(func(Task1Variant6.ActionMethod2, false, '!'));
        }
        public static void PlayGame()
        {
            Ping ping = new Ping("Andrew");
            Pong pong = new Pong("Kate");
            Pong pong1 = new Pong("Mark");
            Game.Play(ping, pong);

            Console.WriteLine();
            Game.Play(ping, pong1);
        }
    }
}
