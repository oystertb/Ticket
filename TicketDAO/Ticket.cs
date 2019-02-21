using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDAO
{
    public class Ticket
    {
        public List<Seat> MySeats { get; set; }
        public User UserBought { get; set; }
    }
}
