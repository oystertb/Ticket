using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDAO
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public bool Taken { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
    }
}
