using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AG_TicketPass.Shared.Enums.EntrancePlaceType;

namespace AG_TicketPass.Shared.Entities
{
    public  class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime UseDate { get; set; } = new DateTime();

        public bool Used { get; set; } = false;

        public Entrance? EntrancePlaceType { get; set; } = null;
    }
}
