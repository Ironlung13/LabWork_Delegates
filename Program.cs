using System;

namespace LabWork_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task:");
            Console.WriteLine("1: Func<Action<>, float, float>");
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
        }
        public static void TaskNumber1()
        {
            Func<Action<object>, float, float> func = Task1.Method1;
            func += Task1.Method2;
            func += Task1.Method3;
            Console.WriteLine("Using PrintInfo1 method:");
            Console.WriteLine(func(Task1.PrintInfo1, 25.0f));
            Console.WriteLine();
            Console.WriteLine("Using PrintInfo2 method:");
            Console.WriteLine(func(Task1.PrintInfo2, 39999.0f));
        }
        public static void PlayGame()
        {
            Ping ping = new Ping("Andrew");
            Pong pong = new Pong("Kate");
            Game.Play(ping, pong);
            Console.ReadLine();
        }
    }
}
