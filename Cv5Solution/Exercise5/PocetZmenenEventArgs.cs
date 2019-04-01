using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public delegate void PocetZmenenEventHandler(object sender, PocetZmenenEventArgs args);

    public class PocetZmenenEventArgs : EventArgs
    {
        public int PuvodniPocet { get; set; }
    }
}
