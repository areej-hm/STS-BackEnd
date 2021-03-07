using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Support_Tickets_System.Entities
{
    public class Tickets
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        [MaxLength(200)]
        [Required]
        public string TicketName { get; set; }

        [Required]
        public int TicketNumber { get; set; }

        [Required]
        public string TicketType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string Note { get; set; }

        public virtual Client Client { get; set; }


    }
}
