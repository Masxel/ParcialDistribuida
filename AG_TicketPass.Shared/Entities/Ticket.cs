using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AG_TicketPass.Shared.Enums.EntrancePlaceType;

namespace AG_TicketPass.Shared.Entities
{
    public  class Ticket
    {

        public int IdTicket { get; set; }

        public DateTime UseDate { get; set; }

        public bool Used { get; set; } = false;

        public Entrance? EntrancePlaceType { get; set;}
    }
}
