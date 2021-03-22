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
            Console.WriteLine("3: Task 3");
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
                case "3":
                    Console.Clear();
                    Task3();
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
            //Используем два разных набора параметров.
            Console.WriteLine("Using ActionMethod1 method:");
            Console.WriteLine(func(Task1Variant6.ActionMethod1, true, 'Y'));
            Console.WriteLine();
            //Второй набор
            Console.WriteLine("Using ActionMethod2 method:");
            Console.WriteLine(func(Task1Variant6.ActionMethod2, false, '!'));
        }
        public static void PlayGame()
        {
            //Создаем три игрока.
            Ping ping = new Ping("Andrew");
            Pong pong = new Pong("Kate");
            Pong pong1 = new Pong("Mark");
            //Сначала сыграют Андрей и Катя. Происходит подписка на события друг друга.
            //По окончанию игры происходит отписка.
            Game.Play(ping, pong);
            Console.WriteLine();
            //Потом сыграют Андрей и Марк. Метод для демонстрации успешной отписки после предыдущей игры, и последующей подписки на новые.
            Game.Play(ping, pong1);
        }

        public static void Task3()
        {
            //Создаем 2 оружия.
            //Разряженный пистолет, который может держать 15 патронов.
            //Ружье, которое может держать 5 патронов. 3 патрона заряжено.
            Gun Pistol = new Gun(15);
            Gun Rifle = new Gun(5, 3);
            //Перезаряжаем пистолет. Теперь внутри него 15 патронов.
            Pistol.Reload();
            //Стреляем 20 раз из пистолета. (Вызывается событие, которое срабатывает определенное количество раз)
            Console.WriteLine("Firing pistol:");
            Pistol.FireRounds(20);
            Console.WriteLine();
            //Стреляем из ружья 4 раза.
            Console.WriteLine("Firing rifle:");
            Rifle.FireRounds(4);
        }
    }
}
