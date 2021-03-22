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
        public event EventHandler<string> ReceivedBall;
        public void OnReceivedBall(object sender, string e)
        {
            Thread.Sleep(500);
            Console.Beep();
            Console.WriteLine($"{Name} received ball from {e}.");
            ReceivedBall(this, Name);
        }
    }
}
