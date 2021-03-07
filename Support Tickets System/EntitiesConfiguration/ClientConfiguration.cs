using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;


namespace Support_Tickets_System.EntitiesConfiguration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entity)
    {
            entity.HasIndex(e => new {e.UserName}).IsUnique();

            entity.HasIndex(e => e.ClientTypeId);
            entity.HasOne(e => e.ClientType).WithMany().HasForeignKey(e => e.ClientTypeId);

            entity.HasData(
                    new Client
                    {
                        ID = 1,
                        CreationDate = DateTime.Now,
                        ClientName = "Admin",
                        UserName = "admin",
                        Password = "123456",
                        ClientAddress = "jenin",
                        ClientPhone = "059538212",
                        ClientTypeId = 1
                    },
                     new Client
                     {
                         ID = 2,
                         CreationDate = DateTime.Now,
                         ClientName = "Areej haj",
                         UserName = "areej77",
                         Password = "123456",
                         ClientAddress = "jenin",
                         ClientPhone = "059538212",
                         ClientTypeId = 2
                     },
                      new Client
                      {
                          ID = 3,
                          CreationDate = DateTime.Now,
                          ClientName = "Ahmad haj",
                          UserName = "ahmad11h",
                          Password = "123456",
                          ClientAddress = "tulkarm",
                          ClientPhone = "059538212",
                          ClientTypeId = 2
                      });



    }
    }
}
