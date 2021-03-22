using System;
using System.Threading;

namespace LabWork_Delegates
{
    public class Gun
    {
        public Gun()
        {
            TriggerPulled += OnTriggerPulled;
        }
        public Gun(int capacity) : this()
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Can't create Gun with capacity <= 0.");
            }
            Capacity = capacity;
        }
        public Gun(int capacity, int rounds) : this(capacity)
        {
            if (rounds < 0)
            {
                throw new ArgumentException("Can't load negative ammount of rounds.");
            }
            if (rounds > capacity)
            {
                Console.WriteLine("Can't insert more rounds than the gun's capacity would allow.");
                Cartridges = capacity;
            }
            else
            {
                Cartridges = rounds;
            }
        }
        public int Cartridges { get; private set; } = 0;
        public int Capacity { get; } = 10;
        private event EventHandler<int> TriggerPulled;

        public void Reload()
        {
            Cartridges = Capacity;
        }
        public void FireRounds(int ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Can't fire gun negative ammount of times.");
            }
            TriggerPulled(this, ammount);
        }
        public void OnTriggerPulled(object sender, int e)
        {
            if (e > 0)
            {
                Thread.Sleep(300);
                if (Cartridges != 0)
                {
                    //Оружие заряжено
                    Console.WriteLine("BANG!");
                    Cartridges--;
                }
                else
                {
                    //Закончились патроны
                    Console.WriteLine("click.");
                }
                TriggerPulled(this, --e);
            }
        }
    }
}
