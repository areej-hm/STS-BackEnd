using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Support_Tickets_System.EntitiesConfiguration
{
    public class ClientTypeConfiguration
    {
        public ClientTypeConfiguration(EntityTypeBuilder<ClientType> entity)
        {
            entity.HasIndex(e => new { e.NameType }).IsUnique();
            entity.HasData(
                 new ClientType
                 {
                     ID = 1,
                     NameType = "Admin"
                 },
                  new ClientType
                  {
                      ID = 2,
                      NameType = "Client"
                  });


        }
    }
}
