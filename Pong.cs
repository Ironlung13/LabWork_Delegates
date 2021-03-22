using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LabWork_Delegates
{
    public class Pong
    {
        public Pong(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public bool Playing { get; set; } = false;
        public event EventHandler<PingPongEventArgs> ReceivedBall;
        public void OnReceivedBall(object sender, PingPongEventArgs e)
        {
            Thread.Sleep(500);
            if (e.counter >= 15)
            {
                Random rand = new Random();
                int change = rand.Next(1, 10);
                if (change >= 5)
                {
                    Console.WriteLine($"{Name} dropped the ball!");
                    return;
                }
            }
            Console.WriteLine($"{Name} received ball from {e.name}.");
            e.counter++;
            ReceivedBall(this, new PingPongEventArgs(Name, e.counter));
        }
    }
}
