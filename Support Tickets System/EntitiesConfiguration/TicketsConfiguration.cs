using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Support_Tickets_System.EntitiesConfiguration
{
    public class TicketsConfiguration
    {
        public TicketsConfiguration(EntityTypeBuilder<Tickets> entity)
        {
            entity.HasIndex(e => new { e.TicketNumber }).IsUnique();
            entity.HasIndex(e => new { e.ClientId });
            entity.HasOne(e => e.Client).WithMany(e=>e.Tickets).HasForeignKey(e => e.ClientId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade); ;
            entity.HasData(
               new Tickets
               {
                   ID = 1,
                   ClientId = 2,
                   CreationDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   StartDate = DateTime.Now,
                   Note = "vip",
                   TicketName = "Franch",
                   TicketNumber = 100001,
                   TicketType = "Round-trip"


               }, new Tickets
               {
                   ID = 2,
                   ClientId = 2,
                   CreationDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   StartDate = DateTime.Now,
                   Note = "vip",
                   TicketName = "jordan",
                   TicketNumber = 100002,
                   TicketType = "Round-trip"


               },
                   new Tickets
                   {
                       ID = 3,
                       ClientId = 3,
                       CreationDate = DateTime.Now,
                       EndDate = DateTime.Now,
                       StartDate = DateTime.Now,
                       Note = "normal",
                       TicketName = "iraq",
                       TicketNumber = 100003,
                       TicketType = "On way only"


                   });

        }
    }
}
