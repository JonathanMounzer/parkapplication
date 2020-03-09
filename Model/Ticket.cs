using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkApplication
{
    class Ticket
    {
        public Zone zone { get; set; }
        public int ticketnr { get; set; }
        public String pnr { get; set; }
        public int zonenr { get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }
    }
}
