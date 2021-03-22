using System;

namespace LabWork_Delegates
{
    public static class Game
    {
        public static void Play(Ping ping, Pong pong)
        {
            //Проверка на доступность игроков
            if (ping.Playing || pong.Playing)
            {
                Console.WriteLine($"{ping.Name} is unable to play with {pong.Name}");
                return;
            }
            //Подписка на события
            ping.Playing = true;
            pong.Playing = true;
            //События отбивания мячика
            ping.ReceivedBallEvent += pong.OnReceivedBall;
            pong.ReceivedBallEvent += ping.OnReceivedBall;
            //События конца игры
            ping.GameEndedEvent += pong.OnGameEnd;
            pong.GameEndedEvent += ping.OnGameEnd;
            //Первый игрок подает
            ping.Serve();
        }
    }
}
