using System;
using System.Threading;

namespace LabWork_Delegates
{
    public class Ping
    {
        public Ping(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public bool Playing { get; set; } = false;
        public event EventHandler<PingPongEventArgs> ReceivedBallEvent;
        public event EventHandler<bool> GameEndedEvent;
        public void OnReceivedBall(object sender, PingPongEventArgs e)
        {
            Thread.Sleep(500);
            //Проверка на конец игры
            if (e.counter >= 15)
            {
                Random rand = new Random();
                int change = rand.Next(1, 10);
                if (change >= 5)
                {
                    Console.WriteLine($"{Name} dropped the ball!");
                    GameEndedEvent(this, true);
                    return;
                }
            }
            //Если игрок не проиграл, инвоцируем событие (мяч летит к другому игроку)
            Console.WriteLine($"{Name} received ball from {e.name}.");
            e.counter++;
            ReceivedBallEvent(this, new PingPongEventArgs(Name, e.counter));
        }
        public void OnGameEnd(object sender, bool e)
        {
            //После окончания игры. Отписка от событий, сброс доступности игрока
            Playing = false;
            ReceivedBallEvent = null;
            //Если проиграл этот игрок (e == true), то триггерим событие, чтобы отписать другого игрока и сбросить его статус.
            //Если проиграл другой игрок (e == false), значит он уже отписался, поэтому пропускаем триггер.
            if (e)
            {
                GameEndedEvent(this, false);
            }
            GameEndedEvent = null;
        }
        public void Serve() //Первая подача
        {
            if (Playing)
            {
                Console.WriteLine($"{Name} is serving.");
                ReceivedBallEvent(this, new PingPongEventArgs(Name, 1));
            }
            else
            {
                return;
            }
        }
    }
}
