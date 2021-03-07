using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Support_Tickets_System.Entities
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
      
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [MaxLength(200)]
        [Required]
        public string ClientName { get; set; }

        [ForeignKey("ClientTypeId")]
        [Required]
        public int ClientTypeId { get; set; }

        [Required]
        public string ClientAddress { get; set; }

        [Required]
        public string ClientPhone { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ClientType ClientType { get; set; }

        public List<Tickets> Tickets { get; set; }
    }
}
