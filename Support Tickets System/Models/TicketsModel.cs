using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support_Tickets_System.Models
{
    public class TicketsModel
    {
        public int ID { get; set; }

        public int ClientId { get; set; }

        public string TicketName { get; set; }


        public int TicketNumber { get; set; }

        public string TicketType { get; set; }


        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string Note { get; set; }

        public virtual ClientModel Client { get; set; }
    }
}
