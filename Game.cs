using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Delegates
{
    public static class Game
    {
        public static void Play(Ping ping, Pong pong)
        {
            if (ping.Playing || pong.Playing)
            {
                Console.WriteLine($"{ping.Name} is unable to play with {pong.Name}");
                return;
            }
            ping.Playing = true;
            pong.Playing = true;
            ping.ReceivedBall += pong.OnReceivedBall;
            pong.ReceivedBall += ping.OnReceivedBall;
            ping.GameEnded += pong.OnGameEnd;
            pong.GameEnded += ping.OnGameEnd;
            ping.Serve();
        }
    }
}
