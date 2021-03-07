using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support_Tickets_System.Models
{
    public class ClientModel
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ClientName { get; set; }

        public int ClientTypeId { get; set; }


        public string ClientAddress { get; set; }

        public string ClientPhone { get; set; }

        public DateTime CreationDate { get; set; }

       // public List<TicketsModel> Tickets { get; set; }
    }
}
