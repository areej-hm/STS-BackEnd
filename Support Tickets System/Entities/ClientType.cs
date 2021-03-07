using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Support_Tickets_System.Entities
{
    public class ClientType
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NameType { get; set; }

    }
}
