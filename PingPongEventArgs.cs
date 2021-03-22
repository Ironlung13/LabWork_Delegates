using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Delegates
{
    public class PingPongEventArgs : EventArgs
    {
        public PingPongEventArgs(string n, int count)
        {
            name = n;
            counter = count;
        }
        public string name;
        public int counter;
    }
}
